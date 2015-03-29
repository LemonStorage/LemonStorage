namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class LaptopBag : Accessories, IProduct
    {
        private string material;
        private double compatibility; //Example: for laptop 15 inches

         public LaptopBag(int price, string brand, string model, string color, string type, string material, double compatibility)
            : base(price, brand, model, color, type)
        {
            this.Material = material;
            this.Compatibility = compatibility;
        }

         public string Material
         {
             get { return this.material; }
             set
             {
                 if (string.IsNullOrEmpty(this.material))
                 {
                     throw new ArgumentNullException("Material can not be empty");
                 }
                 this.material = value;
             }
         }

         public double Compatibility
         {
             get { return this.compatibility; }
             set
             {
                 if (value<0)
                 {
                     throw new ArgumentNullException("Compatibility can not be negative number!");
                 }
                 this.compatibility = value;
             }
         }
    }
}
