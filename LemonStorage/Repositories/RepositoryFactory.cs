using LemonStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStorage.Repositories
{
    public static class RepositoryFactory
    {
        public static IProductRepository GetRepository(string repositoryType)
        {
            switch (repositoryType)
            {
                case "SQL":
                    return new SQLRepository();
                case "CSV":
                    return new CSVRepository();
                case "JSON":
                    return new JSONRepository();
                case "XML":
                    return new XMLRepository();
                default: throw new ArgumentException("No such type of repository");
            }
        }
    }
}
