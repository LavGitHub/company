using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Company
{

    public abstract class Department
    {
        
        public List<Employee> Employees;
        public TaskType TaskType { get; set; }

        public bool CheckTask(Task task)
        {
            foreach (Employee e in Employees)
            {
                if (e.Specialization == task.Type && e.TimeToComplete <= task.TimeInHours)
                {
                    return true;
                }
            }
            return false;
        }

        public Product MakeProduct(Task task)
        {
            if (CheckTask(task))
            {
                var employee = Employees
                    .Where(e
                        => e.Specialization == task.Type && e.TimeToComplete <= task.TimeInHours
                        )
                    .OrderBy(e
                        => e.CountOfTasks
                        )
                    .First();
                return employee.MakeTask(task);
            }

            return null;
        }
    }
}