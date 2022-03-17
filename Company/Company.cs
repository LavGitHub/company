using System;
using System.Collections.Generic;
using System.Linq;

namespace Company
{
    public class Company
    {
        public string CompanyName { get; set; }

        private List<Department> Departments;

        public Company(string companyName, List<Department> departments)
        {
            CompanyName = companyName;
            Departments = departments;
        }

        public List<Task> GetTasks(Order order)
        {
            var tasks = new List<Task>();
            foreach (TaskType i in order.OrderTypes)
            {
                var task  = (new Task{
                    Type = i,
                    Description = "This is task",
                    Name = "Task for order"+order.Name,
                    TimeInHours = order.TimeInHours
                });
                tasks.Add(task);
            }
            return tasks;
        }
        
        public bool CheckOrder(Order order)
        {
            foreach (Task task in GetTasks(order))
            {
                var department = Departments.First(d => d.TaskType == task.Type);
                if (!department.CheckTask(task))
                    return false;
            }

            return true;
        }

        public bool CompleteTheOrder(Order order, ref Product[] completedProducts)
        {
            var tasks = GetTasks(order);
            var products = new List<Product>();
            if (!CheckOrder(order))
                return false;
            foreach (Task task in tasks)
            {
                var department = Departments.First(d => d.TaskType == task.Type);
                var product  = department.MakeProduct(task);
                products.Add(product);
            }
            completedProducts = products.ToArray();
            return true;
        }
        
    }
}