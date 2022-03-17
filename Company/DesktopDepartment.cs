using System.Collections.Generic;

namespace Company
{
    public class DesktopDepartment:Department
    {
        public DesktopDepartment(List<Employee> employees)
        {
            TaskType = TaskType.DesktopApp;
            Employees = employees;
        }
    }
}