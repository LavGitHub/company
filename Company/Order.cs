namespace Company
{
    public class Order
    {
        public string Name { get; set; }
        public TaskType[] OrderTypes { get; set; }
        public int TimeInHours { get; set; }
        private bool status;

        public Order(string name, TaskType[] orderTypes, int timeInHours)
        {
            Name = name;
            OrderTypes = orderTypes;
            TimeInHours = timeInHours;
            status = false;
        }
    }
}