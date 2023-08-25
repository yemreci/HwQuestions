namespace Odev.Q5
{
    internal class TaskManager
    {
        public List<TaskItem> TaskItems { get; set; }
        public TaskManager() 
        {
            TaskItems = new List<TaskItem>();
        }
        public void AddTaskItem(TaskItem item) 
        {
            TaskItems.Add(item);
        }
        public void RemoveTaskItem(TaskItem item)
        {
            TaskItems.Remove(item);
        }
        public void ShowTaskItems() 
        {
            foreach (TaskItem item in TaskItems)
            {
                Console.WriteLine("{0} task's: \n description: {1}\n Enddate {2}\n Status: {3} ", item.Header,item.Description,item.EndDate,item.Status);
            }
        }
    }
}
