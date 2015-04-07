using LemonStorage.Interfaces;
using System;

namespace LemonStorage.Repositories
{
    public class CSVRepository : Repository, IProductRepository
    {
        public override void Run()
        {
            Console.WriteLine("Used CSV Repository");
        }
    }
}
