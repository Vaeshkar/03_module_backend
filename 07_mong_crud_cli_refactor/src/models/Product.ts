import mongoose, { Schema, Document } from 'mongoose';

export interface IProduct extends Document {
  name: string;
  stock: number;
  price: number;
  tags: string[];
  created_at: Date;
}

const ProductSchema: Schema = new Schema({
  name: {
    type: String,
    required: true,
    trim: true
  },
  stock: {
    type: Number,
    required: true,
    min: 0
  },
  price: {
    type: Number,
    required: true,
    min: 0
  },
  tags: [{
    type: String,
    trim: true
  }],
  created_at: {
    type: Date,
    default: Date.now
  }
});

export const Product = mongoose.model<IProduct>('Product', ProductSchema);