namespace Company
{
    public abstract class Product
    {
        public string Name { get; set; }
        public TaskType Type { get; set; }

        public abstract string GetTitle();
    }
    
    
}