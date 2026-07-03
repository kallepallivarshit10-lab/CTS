using System;
using System.Collections.Generic;

public class Inventory
{
    private Dictionary<int, Product> products =
        new Dictionary<int, Product>();

    // Add Product
    public void AddProduct(Product product)
    {
        products[product.ProductId] = product;
        Console.WriteLine("Product Added Successfully");
    }

    // Update Product
    public void UpdateProduct(int id, int quantity)
    {
        if (products.ContainsKey(id))
        {
            products[id].Quantity = quantity;
            Console.WriteLine("Product Updated Successfully");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    // Delete Product
    public void DeleteProduct(int id)
    {
        if (products.Remove(id))
        {
            Console.WriteLine("Product Deleted Successfully");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    // Display Products
    public void DisplayProducts()
    {
        foreach (Product product in products.Values)
        {
            product.Display();
            Console.WriteLine();
        }
    }
}
