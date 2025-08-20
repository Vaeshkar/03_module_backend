import { model } from 'mongoose';
import { postSchema } from '../schemas/index.ts';

// Model
export const Post = model('Post', postSchema);
