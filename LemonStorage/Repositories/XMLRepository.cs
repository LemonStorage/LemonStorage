using LemonStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStorage.Repositories
{
    public class XMLRepository : Repository, IProductRepository
    {
        public override void Run()
        {
            Console.WriteLine("Used XML Repository");
        }
    }
}
