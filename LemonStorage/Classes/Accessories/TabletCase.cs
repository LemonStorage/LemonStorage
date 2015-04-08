namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class TabletCase : Accessories, IAccessories, IProduct, ISavable
    {
        private string compatibility;//With which tablet is it compatible
        private TabletCaseCharacterics characteristics = new TabletCaseCharacterics();

        public TabletCase(int price, string brand, string model, string color, string material, string compatibility, TabletCaseCharacterics chatacteristics)
            : base(price, brand, model, color, material)
        {
            this.Compatibility = compatibility;
            this.characteristics = chatacteristics;

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

