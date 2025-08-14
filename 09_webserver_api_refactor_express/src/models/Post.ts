import mongoose, { Document, Schema } from "mongoose";

export interface PostType extends Document {
  title: string;
  content: string;
  author: string;
  createdAt: Date;
  updatedAt: Date;
}

const PostSchema = new Schema<PostType>({
  title: { type: String, required: true },
  content: { type: String, required: true },
  author: { type: String, required: true },
  createdAt: { type: Date, default: Date.now },
  updatedAt: { type: Date, default: Date.now },
});

export const Post = mongoose.model<PostType>("Post", PostSchema);
