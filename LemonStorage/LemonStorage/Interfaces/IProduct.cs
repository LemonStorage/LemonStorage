namespace LemonStorage.Interfaces
{
    public interface IProduct
    {
        public decimal Price { get; set; }

        public uint Quantity { get; set; }
    }
}
