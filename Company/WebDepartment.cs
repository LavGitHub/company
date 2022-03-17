using System.Collections.Generic;

namespace Company
{
    public class WebDepartment:Department
    {
        public WebDepartment(List<Employee> employees)
        {
            TaskType = TaskType.WebApp;
            Employees = employees;
        }
    }
}