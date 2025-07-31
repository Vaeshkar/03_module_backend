import "#db";
import { Product } from "./models/Product.ts";
import { Command } from "commander";
import { Types } from "mongoose";

const program = new Command();
program
  .name("ecommerce-cli")
  .description("Simple product CRUD CLI")
  .version("1.0.0");

// CREATE
// npm start add <name> <stock> <price> <tags>
program
  .command("add")
  .description("Add a new product")
  .argument("<name>", "Product name")
  .argument("<stock>", "Stock quantity")
  .argument("<price>", "Product price")
  .argument("<tags>", "Comma-separated tags")
  .action(async (name, stockStr, priceStr, tagsStr) => {
    const stock = parseInt(stockStr);
    const price = parseFloat(priceStr);
    const tags = tagsStr.split(",").map((tag: string) => tag.trim());

    try {
      const product = new Product({
        name,
        stock,
        price,
        tags,
      });

      const result = await product.save();
      console.log("Product added:", result._id);
    } catch (error) {
      console.error("Error adding product:", error);
    }
  });

// READ
// npm start list
program
  .command("list")
  .description("List all products")
  // list all products

  .action(async () => {
    try {
      const products = await Product.find();
      console.log(products);
    } catch (error) {
      console.error("Error listing products:", error);
    }
  });

// UPDATE
// npm start update <id> <name> <stock> <price>
program
  .command("update")
  .description("Update a product")
  .argument("<id>", "Product ID")
  .argument("<name>", "Product Name")
  .argument("<stock>", "Stock Quantity")
  .argument("<price>", "Product Price")
  .action(async (id, name, stockStr, priceStr) => {
    const stock = parseInt(stockStr);
    const price = parseFloat(priceStr);

    try {
      if (!Types.ObjectId.isValid(id)) {
        console.error("Invalid product ID");
        return;
      }

      const result = await Product.findByIdAndUpdate(
        id,
        { name, stock, price },
        { new: true, runValidators: true }
      );

      if (result) {
        console.log("Product updated:", result);
      } else {
        console.log("Product not found");
      }
    } catch (error) {
      console.error("Error updating product:", error);
    }
  });

// DELETE
// npm start delete <id>
program
  .command("delete")
  .description("Delete a product")
  .argument("<id>", "Product ID")
  .action(async (id) => {
    try {
      if (!Types.ObjectId.isValid(id)) {
        console.error("Invalid product ID");
        return;
      }

      const result = await Product.findByIdAndDelete(id);

      if (result) {
        console.log("Product deleted:", result._id);
      } else {
        console.log("Product not found");
      }
    } catch (error) {
      console.error("Error deleting product:", error);
    }
  });

// SEARCH BY TAG
// npm start search <tag>
program
  .command("search")
  .description("Search products by tag")
  .argument("<tag>", "Tag to search for")
  .action(async (tag) => {
    try {
      const products = await Product.find({ tags: { $in: [tag] } });

      if (products.length > 0) {
        console.log(`Found ${products.length} product(s) with tag "${tag}":`);
        console.log(products);
      } else {
        console.log(`No products found with tag "${tag}"`);
      }
    } catch (error) {
      console.error("Error searching products:", error);
    }
  });

// GET BY ID
// npm start get <id>
program
  .command("get")
  .description("Get a product by ID")
  .argument("<id>", "Product ID")
  .action(async (id) => {
    try {
      if (!Types.ObjectId.isValid(id)) {
        console.error("Invalid product ID");
        return;
      }

      const product = await Product.findById(id);

      if (product) {
        console.log("Product found:", product);
      } else {
        console.log("Product not found");
      }
    } catch (error) {
      console.error("Error getting product:", error);
    }
  });

program.hook("postAction", () => process.exit(0));
program.parse();
