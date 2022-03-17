namespace Company
{
    
        public class MobileDeveloper : Employee
        {
            public MobileDeveloper(FullName name, int countOfTasks, int timeToComplete) : base(name, countOfTasks, timeToComplete)
            {
                Specialization = TaskType.MobileApp;
            }

            public override Product MakeTask(Task task)
            {
                if (CheckTime(task))
                {
                    CountOfTasks++;
                    return new ProductMobileApp(task.Name, task.Type);
                }
            
                return null;
            }
        }
        
}
