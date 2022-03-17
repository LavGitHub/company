using System.Collections.Generic;

namespace Company
{
    public class MobileDepartment:Department
    {
        public MobileDepartment(List<Employee> employees)
        {
            TaskType = TaskType.MobileApp;
            Employees = employees;
        }
    }
}