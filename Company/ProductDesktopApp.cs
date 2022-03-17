namespace Company
{
    public class ProductDesktopApp:Product
    {
        public ProductDesktopApp(string name, TaskType type)
        {
            Name = name;
            Type = type;
        }

        public override string GetTitle()
        {
            return "Desktop Application";
        }
    }
}