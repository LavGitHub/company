namespace Company
{
    public class WebDeveloper:Employee
    {
        public WebDeveloper(FullName name, int countOfTasks, int timeToComplete) : base(name, countOfTasks, timeToComplete)
        {
            Specialization = TaskType.WebApp;
        }

        public override Product MakeTask(Task task)
        {
            if (CheckTime(task))
            {
                CountOfTasks++;
                return new ProductWebApp(task.Name, task.Type);
            }
            
            return null;
        }
    }
}