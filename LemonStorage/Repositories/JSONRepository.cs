using LemonStorage.Interfaces;
using System;

namespace LemonStorage.Repositories
{
    public class JSONRepository : Repository, IProductRepository
    {
        public override void Run()
        {
            Console.WriteLine("Used JSON Repository");
        }
    }
}
