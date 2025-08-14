import express, { type Request, type Response } from "express";
import "dotenv/config";
import { connectDB } from "./db.index.ts";
import { Post, type PostType } from "./models/Post.ts";

// Connect to the database
connectDB();

// Define request body types
type PostRequestBody = {
  title: string;
  content: string;
  author: string;
};

// PostParams
type PostParams = {
  id: string;
};

// Create express app
const app = express();
const port = process.env.PORT || 3000;

// Middleware to parse JSON bodies
app.use(express.json());

// GET all posts
app.get("/posts", async (req: Request, res: Response) => {
  try {
    const posts = await Post.find();
    res.json(posts);
  } catch (error) {
    res.status(500).json({ error: "Failed to fetch posts" });
  }
});

// GET post by id
app.get("/posts/:id", async (req: Request<PostParams>, res: Response) => {
  try {
    const { id }: PostParams = req.params;
    console.log("Looking for post with ID:", id);
    const post = await Post.findById(id);
    if (!post) {
      return res.status(404).json({ error: "Post not found" });
    }
    console.log("Found post:", post);
    res.json(post);
  } catch (error) {
    console.error("Error fetching post:", error);
    res.status(500).json({ error: "Failed to fetch post" });
  }
});

// POST create post
app.post(
  "/posts",
  async (req: Request<{}, {}, PostRequestBody>, res: Response) => {
    try {
      console.log("Received body:", req.body);
      const { title, content } = req.body;
      const newPost = new Post({
        title,
        content,
        author: req.body.author,
      });
      console.log("About to save:", newPost);

      const savedPost = await newPost.save();
      console.log("Saved successfully:", savedPost);
      res.status(201).json(savedPost);
    } catch (error) {
      console.error("Error creating post:", error);
      res.status(500).json({ error: "Failed to create post" });
    }
  }
);

// PUT update post
app.put(
  "/posts/:id",
  async (req: Request<PostParams, {}, PostRequestBody>, res: Response) => {
    try {
      const { id } = req.params;
      const { title, content } = req.body;
      const updatedPost = await Post.findByIdAndUpdate(
        id,
        { title, content, updatedAt: Date.now() },
        { new: true }
      );

      if (!updatedPost) {
        return res.status(404).json({ error: "Post not found" });
      }
      res.json(updatedPost);
    } catch (error) {
      res.status(500).json({ error: "Failed to update post" });
    }
  }
);

// DELETE post
app.delete("/posts/:id", async (req: Request<PostParams>, res: Response) => {
  try {
    const { id } = req.params;
    const deletedPost = await Post.findByIdAndDelete(id);
    if (!deletedPost) {
      return res.status(404).json({ error: "Post not found" });
    }
  } catch (error) {
    res.status(500).json({ error: "Failed to delete post" });
  }
});

// START server
app.listen(port, () => {
  console.log(`Server is running on port ${port}`);
});
