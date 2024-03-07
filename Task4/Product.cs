namespace Task4;

public class Product
{

    string _name;
    float _price;
    public Product(string name, float price)
    {
        _name = name;
        _price = price;

    }

    public void PrintProduct(int shtuk)
    {

        System.Console.WriteLine($"Name:{_name} Price: {_price} Shtuk: {shtuk}");
    }



}
