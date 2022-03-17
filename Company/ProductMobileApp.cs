namespace Company
{
    public class ProductMobileApp:Product
    {
        public ProductMobileApp(string name, TaskType type)
        {
            Name = name;
            Type = type;
        }

        public override string GetTitle()
        {
            return "Mobile Application";
        }
    }
}