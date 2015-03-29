namespace LemonStorage.Classes.Accessories
{
    using LemonStorage.Interfaces;

    public abstract class Accessories : Product, IProduct
    {
        public Accessories(int price, string brand, string model, string color)
            : base(price, brand, model, color)
        {

        }

        public abstract void Save();

        public abstract void Load();
    }
}
