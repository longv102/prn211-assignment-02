using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class FlowerBouquetDAO
    {
        private FlowerBouquetDAO() { }
        private static readonly object instanceLock = new object();
        private static FlowerBouquetDAO instance;
        public static FlowerBouquetDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new FlowerBouquetDAO();
                    }
                    return instance;
                }
            }
        }

        public List<FlowerBouquet> GetFlowers()
        {
            try
            {
                List<FlowerBouquet> flowers = null;
                var context = new FuflowerBouquetManagementV4Context();
                flowers = context.FlowerBouquets.ToList();
                return flowers;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public FlowerBouquet SearchFlowerById(int flowerId)
        {
            try
            {
                FlowerBouquet flower = null;
                var context = new FuflowerBouquetManagementV4Context();
                flower = context.FlowerBouquets.FirstOrDefault(f => f.FlowerBouquetId == flowerId);
                return flower;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FlowerBouquet> SearchFlowerByName(string name)
        {
            try
            {
                List<FlowerBouquet> flowers = null;
                var context = new FuflowerBouquetManagementV4Context();
                flowers = context.FlowerBouquets.Where(f => f.FlowerBouquetName.Contains(name)).ToList();
                return flowers;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteAFlower(int flowerId)
        {
            try
            {
                var context = new FuflowerBouquetManagementV4Context();
                FlowerBouquet deletedFlower = context.FlowerBouquets.Find(flowerId);
                if (deletedFlower != null)
                {
                    bool isExisted = context.OrderDetails.Any(ord => ord.FlowerBouquetId == deletedFlower.FlowerBouquetId);
                    if (isExisted) throw new Exception("Cannot delete this flower!");
                    deletedFlower.FlowerBouquetStatus = 0;
                    context.FlowerBouquets.Update(deletedFlower);
                    context.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FlowerBouquet> SearchFlowerByPrice(decimal start, decimal end)
        {
            try
            {
                List<FlowerBouquet> flowers = null;
                var context = new FuflowerBouquetManagementV4Context();
                if (start <= 0 || end <= 0) throw new Exception("Value MUST be positive!");
                if (start >= end) throw new Exception("Start value MUST be smaller than end value!");
                flowers = context.FlowerBouquets.Where(f => f.UnitPrice >= start && f.UnitPrice <= end).ToList();
                return flowers;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FlowerBouquet> SearchFlowerByQuantity(int start, int end)
        {
            try
            {
                List<FlowerBouquet> flowers = null;
                var context = new FuflowerBouquetManagementV4Context();
                if (start <= 0 || end <= 0) throw new Exception("Value MUST be positive!");
                if (start >= end) throw new Exception("Start value MUST be smaller than end value!");
                flowers = context.FlowerBouquets.Where(f => f.UnitsInStock >= start && f.UnitsInStock <= end).ToList();
                return flowers;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddAFlower(FlowerBouquet flower)
        {

        }

        public void UpdateAFlower(FlowerBouquet flower)
        {

        }

        public List<Category> GetCategories()
        {
            try
            {
                List<Category> categories = null;
                var context = new FuflowerBouquetManagementV4Context();
                categories = context.Categories.ToList();
                return categories;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Supplier> GetSuppliers()
        {
            try
            {
                List<Supplier> suppliers = null;
                var context = new FuflowerBouquetManagementV4Context();
                suppliers = context.Suppliers.ToList();
                return suppliers;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
