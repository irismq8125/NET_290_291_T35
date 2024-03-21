namespace NET_290_291_T35.Models.ToDoTask
{
    public class ToDoTask
    {
        public Guid Id { get; set; }
        public string? TaskName { get; set; }
        public string? StartDay { get; set; }
        public string? EndDay { get; set; }
        public string? Status { get; set; }
        public string? Discription { get; set; }
    }
}
