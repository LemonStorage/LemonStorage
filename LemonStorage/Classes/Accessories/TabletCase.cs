namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class TabletCase :Accessories, IProduct
    {
        private string compatibility;//With which tablet is it compatible

        public TabletCase(int price, string brand, string model, string color, string material, string compatibility)
            : base(price, brand, model, color, material)
        {
             this.Compatibility = compatibility;
        }
         
         public string Compatibility
         {
             get 
             {
                 return this.compatibility;
             }
             set
             {
                 if (string.IsNullOrEmpty(this.compatibility))
                 {
                     throw new ArgumentNullException("Compatibility can not be empty!");
                 }
                 this.compatibility = value;
             }
         }
    }
}

