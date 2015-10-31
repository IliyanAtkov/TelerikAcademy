using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_and_Entity_Framework
{
    public class DAO
    {
        static void Main()
        {
           // Add("Gnc", "SELOOOD", "Kaspichan", "Bulgaria");
           // Edit("ALFKI", "NovoNormalnojIme", "Sofia", "USA");
           // FindCustomersOrdersByYearAndCountry(1997, "Canada");
           // NativeSql(1997, "Canada");
            FindSalesByDateRange("RJ", new DateTime(1996, 7, 5), new DateTime(1996, 7, 14));
        }

        static void Add(string customerID, string companyName, string city, string country)
        {
            var db = new northwindEntities();
            using(db)
            {
                var customer = new Customer() {
                    CustomerID = customerID,
                    CompanyName = companyName,
                    City = city,
                    Country = country
                };

                db.Customers.Add(customer);
                db.SaveChanges();               
            }

        }

        static void Edit(string customerID, string companyName, string city, string country)
        {
            var db = new northwindEntities();
            using (db)
            {
                var customerToEdt = db.Customers.Find(customerID);
                customerToEdt.CompanyName = companyName;
                customerToEdt.City = city;
                customerToEdt.Country = country;
                db.SaveChanges();
            }
        }

        static void Delete(string customerID)
        {
            var db = new northwindEntities();
            using (db)
            {
                var customerToDelete = db.Customers.Find(customerID);
                db.Customers.Remove(customerToDelete);
                db.SaveChanges();
            }
        }

        static void FindCustomersOrdersByYearAndCountry(int year, string country)
        {
            var db = new northwindEntities();
            using (db)
            {
                var findedOrders = db.Orders
                    .Where(x => x.OrderDate.Value.Year == year)
                    .Where(x => x.ShipCountry == country);

                foreach (var order in findedOrders)
                {
                    Console.WriteLine("Customer Name " + order.Customer.ContactName + "Customer ID " + order.Customer.CustomerID);
                }
            }
        }

        static void NativeSql(int year, string country)
        {
            var db = new northwindEntities();
            using (db)
            {
                string sqlQuery = @"SELECT c.ContactName from Customers" +
                            " c INNER JOIN Orders o ON o.CustomerID = c.CustomerID " +
                            "WHERE (YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1});";

                object[] parameters = { year, country };
                var sqlQueryResult = db.Database.SqlQuery<string>(sqlQuery, parameters);

                foreach (var order in sqlQueryResult)
                {
                    Console.WriteLine(order);
                }
            }
        }

        static void FindSalesByDateRange(string region, DateTime startDate, DateTime endDate)
        {
            var db = new northwindEntities();
            using (db)
            {
                var sales = db.Orders
                    .Where(x => x.ShipRegion == region
                    && x.OrderDate > startDate
                    && x.OrderDate < endDate)
                    .Select(x => new
                    {
                        ShipDate = x.ShippedDate,
                        Region = x.ShipRegion
                    });

                db.SaveChanges();
                foreach (var sale in sales)
                {
                    Console.WriteLine("Ship date " + sale.ShipDate + " Ship Region " +  sale.Region);
                }
                    
            }
        }
     
    }
}