import express from 'express';
import { connectDB } from './db/index.ts';
import { userRouter, postRouter } from './routers/index.ts';

// Create express app
export const app = express();
const port = process.env.PORT || 8080;

// Middleware
app.use(express.json());

// Use routers
app.use('/users', userRouter);
app.use('/posts', postRouter);

// Start server
const startServer = async () => {
  try {
    await connectDB();
    app.listen(port, () => {
      console.log(`Server running on port ${port}`);
    });
  } catch (error) {
    console.error('Failed to start server:', error);
    process.exit(1);
  }
};

startServer();
