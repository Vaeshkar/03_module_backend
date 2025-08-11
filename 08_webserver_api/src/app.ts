import http, { type RequestListener } from "node:http";
import "dotenv/config";
import { connectDB } from "./db.index.ts";
import { Post, type PostType } from "./models/Post.ts";

// Connect to the database
connectDB();

// Create a response
const createResponse = (
  res: http.ServerResponse,
  statusCode: number,
  message: unknown
) => {
  res.writeHead(statusCode, { "Content-Type": "application/json" });
  return res.end(
    typeof message === "string"
      ? JSON.stringify({ message })
      : JSON.stringify(message)
  );
};

// Create a request handler
const requestHandler: RequestListener = async (req, res) => {
  const singlePostRegex = /^\/posts\/[0-9a-zA-Z]+$/; // Simple expression to match the pattern /posts/anything
  const { method, url } = req;
  if (url === "/posts") {
    if (method === "GET") {
      try {
        const posts = await Post.find();
        return createResponse(res, 200, posts);
      } catch (error) {
        return createResponse(res, 500, "Error fetching posts:");
      }
    }
    if (method === "POST") {
      let body = "";
      req.on("data", (chunk) => {
        body += chunk.toString();
      });
      req.on("end", async () => {
        try {
          const parsedBody = JSON.parse(body);
          // Here you can access the parsed body
          const newPost = new Post({
            title: parsedBody.title,
            content: parsedBody.content,
            author: parsedBody.author,
            createdAt: parsedBody.date,
          });

          const savedPost = await newPost.save();

          createResponse(res, 201, savedPost);
        } catch (error) {
          return createResponse(res, 400, "Error crating post");
        }
      });
      return;
    }
    return createResponse(res, 405, "Method Not Allowed");
  }
  if (singlePostRegex.test(url!)) {
    if (method === "GET") {
      try {
        const postId = url!.split("/")[2];
        const post = await Post.findById(postId);
        if (!post) {
          return createResponse(res, 404, "Post not found");
        }
        return createResponse(res, 200, post);
      } catch (error) {
        return createResponse(res, 500, "Error fetching post");
      }
    }
    if (method === "PUT") {
      const postId = url!.split("/")[2];

      let body = "";
      req.on("data", (chunk) => {
        body += chunk.toString();
      });

      req.on("end", async () => {
        try {
          const parsedBody = JSON.parse(body);

          const updatedPost = await Post.findByIdAndUpdate(
            postId,
            {
              title: parsedBody.title,
              content: parsedBody.content,
              author: parsedBody.author,
              updatedAt: new Date(),
            },
            { new: true }
          );

          if (!updatedPost) {
            return createResponse(res, 404, "Post not found");
          }
          return createResponse(res, 200, updatedPost);
        } catch (error) {
          return createResponse(res, 500, "Error updating post");
        }
      });
      return;
    }
    if (method === "DELETE") {
      try {
        const postId = url!.split("/")[2];
        const deletedPost = await Post.findByIdAndDelete(postId);
        if (!deletedPost) {
          return createResponse(res, 404, "Post not found");
        }
        return createResponse(res, 200, "Post deleted");
      } catch (error) {
        return createResponse(res, 500, "Error deleting post");
      }
    }
    return createResponse(res, 405, "Method Not Allowed");
  }
  return createResponse(res, 404, "Not Found");
};

// Create a server
const server = http.createServer(requestHandler);

// Start the server
const port = 3000;
server.listen(port, () =>
  console.log(`Server running at <http://localhost>:${port}/`)
);
