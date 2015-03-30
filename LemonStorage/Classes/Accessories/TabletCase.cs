namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class TabletCase :Accessories, IProduct
    {
        private string material;
        private string compatibility;//With which tablet is it compatible

        public TabletCase(int price, string brand, string model, string color, string type, string material, string compatibility)
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

         public string Compatibility
         {
             get { return this.compatibility; }
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

