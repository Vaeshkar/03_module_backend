import express from "express"; // Import express

const app = express(); // Creat your app object
const port = 3000; // Declare a port variable

const posts = [
  { id: 1, title: "Post 1" },
  { id: 2, title: "Post 2" },
  { id: 3, title: "Post 3" },
]; // Simple array to represent data

app.get("/posts", (req, res) => res.json(posts)); // GET `/posts` => returns JSON array of objects
// FOCUS ON THIS
app.get("/posts/:id", (req, res) => {
  const post = posts.find((post) => post.id === parseInt(req.params.id));
  if (!post) return res.status(404).json({ message: "Post not found" });
  return res.json(post);
});
// FOCUS ON THIS

app.listen(port, () => console.log(`Server is running on port ${port}`)); // Spin up server on port 3000
