namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;

    public class Headphone : Accessories, IProduct
    {
          public Headphone(int price, string brand, string model, string color, string type)
            : base(price, brand, model, color,type)
        {
          
        }
    }
}
