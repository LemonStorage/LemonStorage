namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;
    using System;

    public class InEarHeadset : Headphone, IProduct
    {

        private bool connector;

        public InEarHeadset(int price, string brand, string model, string color, string type, bool connector)
            : base(price, brand, model, color, type)
        {
            this.Connector = connector;
        }

        public bool Connector
        {
            get { return this.connector; }
            set { this.connector = value; }
        }

    }
}
