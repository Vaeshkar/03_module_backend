import mongoose from 'mongoose';

try {
  await mongoose.connect(process.env.MONGO_URI!, {
    dbName: 'ecommerce'
  });
  console.log("Connected to MongoDB via Mongoose");
} catch (err) {
  process.env.NODE_ENV !== "production" && console.error(err);
  process.exit(1);
}

export default mongoose;
