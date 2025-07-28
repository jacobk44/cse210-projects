using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();

    }
    // Adding product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);

    }
    // Calculate the total cost including shipping 
    public decimal GetTotalCost()
    {
        decimal productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        decimal shipping = _customer.LiveInUSA() ? 5 : 35;
        return productTotal + shipping;
    }

    // Generate a packing label listing all products 
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetPackingLabel()}\n";

        }
        return label.TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_customer.GetShippingLabel()}";
    }
}