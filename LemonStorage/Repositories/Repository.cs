using LemonStorage.Interfaces;
using System;

namespace LemonStorage.Repositories
{
    public abstract class Repository : IProductRepository
    {
        public Repository()
        {
            this.Run();
        }
        public abstract void Run();
    }
}
