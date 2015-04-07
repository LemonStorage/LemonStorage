namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class PhoneCase : Accessories,IAccessories, IProduct, ISavable
    {
        private string compatibility;//With which phone is it compatible

        public PhoneCase(int price, string brand, string model, string color, string material, string compatibility)
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
                     throw new ArgumentNullException("Compatibility can not empty!");
                 }
                 this.compatibility = value;
             }
         }
    }
}
