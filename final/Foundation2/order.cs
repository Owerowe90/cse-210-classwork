using System;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }

    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }

    public decimal TotalPrice()
    {
        decimal total = 0;

        foreach (Product product in products)
        {
            total += product.Price;
        }

        if (customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in products)
        {
            packingLabel += $"{product.Name} ({product.Id})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}