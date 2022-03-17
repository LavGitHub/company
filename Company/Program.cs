using System;
using System.Collections.Generic;

namespace Company
{
    class Program
    {

        public static void ProductResult(Order order, Product[] products, Company company)
        {
            if (!company.CompleteTheOrder(order, ref products))
            {
                Console.WriteLine("Its not work");
            }
            else
            {
                Console.WriteLine("Done");
                foreach (var product in products)
                {
                    Console.WriteLine(product.Type);
                }
            }
        }
        
        static void Main(string[] args)
        {
            WebDepartment webDepartment = null;
            DesktopDepartment desktopDepartment = null;
            MobileDepartment mobileDepartment = null;
            
            Data.AddBaseDepartments(ref webDepartment, ref desktopDepartment, ref mobileDepartment);
            
            var company = new Company("TestCompany", 
                new List<Department>() {webDepartment, desktopDepartment, mobileDepartment});
            
            Console.WriteLine("Order 1");

            var order1 = new Order("Just an Order", 
                new[] {TaskType.DesktopApp, TaskType.WebApp},
                60);

            var products = new Product[]{};
            ProductResult(order1, products, company);
            
            Console.WriteLine();
            Console.WriteLine("Order 2");
            
            
            var order2 = new Order ("Just an Order 2",
                new [] {TaskType.MobileApp, TaskType.DesktopApp},
                85);
            
            products = new Product[]{};
            ProductResult(order2, products, company);
           
        }
    }
}