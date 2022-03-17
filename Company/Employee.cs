namespace Company
{
    public class FullName                  
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }

        public FullName( string firstName, string secondName, string middleName)
        {
            FirstName = firstName;
            SecondName = secondName;
            MiddleName = middleName; 
        }
    }
    public abstract class Employee
    {
        public FullName Name { get; set; }
        public TaskType Specialization { get; set; }
        public int CountOfTasks { get; set; }
        public int TimeToComplete { get; set; }

        protected Employee(FullName name, int countOfTasks, int timeToComplete)
        {
            Name = name;
            CountOfTasks = countOfTasks;
            TimeToComplete = timeToComplete;
        }

        public abstract Product MakeTask(Task task);

        public bool CheckTime(Task task)
        {
            return (TimeToComplete <= task.TimeInHours);
        }
    }
}