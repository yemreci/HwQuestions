namespace Odev.Q5
{
    internal class TaskItem
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public TaskItem(string header,string description) 
        {
            Header = header;
            Description = description;
            EndDate = DateTime.Now.AddYears(1);
            Status = "Active";
        }
    }
}
