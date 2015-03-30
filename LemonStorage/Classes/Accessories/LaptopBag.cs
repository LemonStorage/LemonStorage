namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class LaptopBag : Accessories, IProduct
    {
        private const double MinCapacity = 7;

        private string material;
        private double maximumCapacityInInches; //Example: for laptop 15.6 inches

        public LaptopBag(int price, string brand, string model, string color, string type, string material, double maximumCapacityInInches)
            : base(price, brand, model, color, type)
        {
            this.Material = material;
            this.MaximumCapacityInInches = maximumCapacityInInches;
        }

         public string Material
         {
             get
             {
                 return this.material; 
             }
             set
             {
                 if (string.IsNullOrEmpty(this.material))
                 {
                     throw new ArgumentNullException("Describe the material!");
                 }
                 this.material = value;
             }
         }

         public double MaximumCapacityInInches
         {
             get 
             {
                 return this.maximumCapacityInInches; 
             }
             set
             {
                 if (value < MinCapacity)
                 {
                     throw new ArgumentNullException(string.Format("Capacity can not be less than {0}!", MinCapacity));
                 }
                 this.maximumCapacityInInches = value;
             }
         }
    }
}
