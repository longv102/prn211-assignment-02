using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FlowerBouquetRepo : IFlowerBouquetRepo
    {
        public void DeleteAFlower(int flowerId) => FlowerBouquetDAO.Instance.DeleteAFlower(flowerId);

        public List<Category> GetCategories() => FlowerBouquetDAO.Instance.GetCategories();

        public List<FlowerBouquet> GetFlowers() => FlowerBouquetDAO.Instance.GetFlowers();

        public List<Supplier> GetSuppliers() => FlowerBouquetDAO.Instance.GetSuppliers();

        public List<FlowerBouquet> SearchFlowerBouquetByPrice(decimal start, decimal end)
            => FlowerBouquetDAO.Instance.SearchFlowerByPrice(start, end);

        public List<FlowerBouquet> SearchFlowerBouquetByQuantity(int start, int end)
            => FlowerBouquetDAO.Instance.SearchFlowerByQuantity(start, end);

        public FlowerBouquet SearchFlowerById(int flowerId) => FlowerBouquetDAO.Instance.SearchFlowerById(flowerId);

        public List<FlowerBouquet> SearchFlowerByName(string name) => FlowerBouquetDAO.Instance.SearchFlowerByName(name);
    }
}
