using System.Collections.Generic;

namespace Company
{
    public static class Data
    {
        public static void AddBaseDepartments(ref WebDepartment wd, ref DesktopDepartment dd, ref MobileDepartment md)
        {
            wd = new WebDepartment(new List<Employee>
            {
                new WebDeveloper(new FullName("Ivanov", "Ivan", "Ivanovich"), 0, 90),
                new WebDeveloper(new FullName("Petrov", "Petr", "Petrovich"),2, 98)
            });
            
            dd = new DesktopDepartment(new List<Employee>
            {
                new DesktopDeveloper(new FullName("Ivanov", "Ivan", "Ivanovich"),1, 78),
                new DesktopDeveloper(new FullName("Petrov", "Petr", "Petrovich"),0, 86)
            });
            
            md = new MobileDepartment(new List<Employee>
            {
                new MobileDeveloper(new FullName("Ivanov", "Oxana", "Ivanovich"),0, 85),
                new MobileDeveloper(new FullName("Petrov", "Petr", "Petrovich"),3, 89)
            });
        }
    }
}