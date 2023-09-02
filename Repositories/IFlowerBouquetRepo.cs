using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFlowerBouquetRepo
    {
        public List<FlowerBouquet> GetFlowers();

        public FlowerBouquet SearchFlowerById(int flowerId);

        public List<FlowerBouquet> SearchFlowerByName(string name);

        public void DeleteAFlower(int flowerId);

        public List<FlowerBouquet> SearchFlowerBouquetByQuantity(int start, int end);

        public List<FlowerBouquet> SearchFlowerBouquetByPrice(decimal start, decimal end);

        public List<Category> GetCategories();

        public List<Supplier> GetSuppliers();
    }
}
