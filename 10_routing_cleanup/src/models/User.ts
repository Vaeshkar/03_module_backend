import { model } from 'mongoose';
import { userSchema } from '../schemas/index.ts';

// Model
export const User = model('User', userSchema);
