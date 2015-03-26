using System;

namespace LemonStorage.Interfaces
{
    public interface IProduct
    {
        decimal Price { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        ConsoleColor Color { get; set; }

        void Save(); //Save in the data base 

        void Load(); //Load from the data base

        void Buy(); //Add products

        void Sell(); //Delete products

        int Quantity(); //Get the quantity from the selected product
       
    }
}