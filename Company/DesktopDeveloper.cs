namespace Company
{
    public class DesktopDeveloper : Employee
    {
        public DesktopDeveloper(FullName name, int countOfTasks, int timeToComplete) : base(name, countOfTasks, timeToComplete)
        {
            Specialization = TaskType.DesktopApp;
        }

        public override Product MakeTask(Task task)
        {
            if (CheckTime(task))
            {
                CountOfTasks++;
                return new ProductDesktopApp(task.Name, task.Type);
            }
            
            return null;
        }
    }
}