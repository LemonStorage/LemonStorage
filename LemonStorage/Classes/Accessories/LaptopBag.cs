namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class LaptopBag : Accessories, IProduct
    {
        private const double MinCapacity = 7;

        private double maximumCapacityInInches; //Example: for laptop 15.6 inches
        private string wearingStyle; //backpack, bag

        public LaptopBag(int price, string brand, string model, string color, string material, double maximumCapacityInInches, string wearingStyle)
            : base(price, brand, model, color, material)
        {
            this.MaximumCapacityInInches = maximumCapacityInInches;
            this.WearingStyle = wearingStyle;
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

         public string WearingStyle
         {
             get
             {
                 return this.wearingStyle;
             }
             set
             {
                 if (string.IsNullOrEmpty(value))
                 {
                     throw new ArgumentNullException("Wearing style can not be empty!");
                 }
                 this.wearingStyle = value;
             }
         }
    }
}
