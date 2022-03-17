namespace Company
{
    public class ProductWebApp:Product
    {
        public ProductWebApp(string name, TaskType type)
        {
            Name = name;
            Type = type;
        }

        public override string GetTitle()
        {
            return "Web Application";
        }
    }
}