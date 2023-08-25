using Odev.Q5;

internal class Program
{
    private static void Main(string[] args)
    {
        TaskItem taskItem1 = new TaskItem("asd","qwe");
        TaskItem taskItem2 = new TaskItem("qwe","asd");
        TaskItem taskItem3 = new TaskItem("zxc","qwe");
        TaskManager taskManager = new TaskManager();
        taskManager.AddTaskItem(taskItem1);
        taskManager.AddTaskItem(taskItem2);
        taskManager.AddTaskItem(taskItem3);
        taskManager.ShowTaskItems();
    }
}