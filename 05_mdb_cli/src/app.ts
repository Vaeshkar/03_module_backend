import { db } from "#db";
import { Command } from "commander";

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
    const product = {
      name,
      stock,
      price,
      tags,
      created_at: new Date(),
    };

    const result = await db.collection("products").insertOne(product);
    console.log("Product added:", result.insertedId);
  });

// READ
// npm start list
program
  .command("list")
  .description("List all products")
  // list all products

  .action(async () => {
    const products = await db.collection("products").find().toArray();
    console.log(products);
    console.log("CLI application was called with list command");
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
    console.log(
      "CLI application was called with update command with arguments:",
      {
        id,
        name,
        stockStr,
        priceStr,
      }
    );
  });

// DELETE
// npm start delete <id>
program
  .command("delete")
  .description("Delete a product")
  .argument("<id>", "Product ID")
  .action(async (id) => {
    console.log(
      "CLI application was called with delete command with arguments:",
      id
    );
  });

// SEARCH BY TAG
// npm start search <tag>
program
  .command("search")
  .description("Search products by tag")
  .argument("<tag>", "Tag to search for")
  .action(async (tag) => {
    console.log(
      "CLI application was called with search command with arguments:",
      tag
    );
  });

// GET BY ID
// npm start get <id>
program
  .command("get")
  .description("Get a prodiuct by ID")
  .argument("<id>", "Product ID")
  .action(async (id) => {
    console.log(
      "CLI application was called with get command with arguments:",
      id
    );
  });

program.hook("postAction", () => process.exit(0));
program.parse();
