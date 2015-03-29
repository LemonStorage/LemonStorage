namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    class Charger : Accessories, IProduct
    {
        private string type;

        public Charger(int price, string brand, string model, string color, string type)
            : base(price, brand, model, color)
        {
            this.Type = type;
        }

        // For car, normal or powerbank
        public string Type 
        {
            get
            {
                if (string.IsNullOrEmpty(this.type))
                {
                    throw new ArgumentNullException("Type of memory card can not be empty");
                }
                return this.type;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Type of memory card can not be empty");
                }
                this.type = value;
            }
        }

        // TODO: Implement the logic of the Charger.Save()
        public override void Save()
        {
            throw new NotImplementedException();
        }
        // TODO: Implement the logic of the Charger.Load()
        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
