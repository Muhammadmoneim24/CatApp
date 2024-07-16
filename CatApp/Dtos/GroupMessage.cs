namespace ChatApp.Dtos
{
    public class GroupMessage
    {
        public int groupId { get; set; }
        public string message { get; set; }
        public IFormFile? file { get; set; }
    }
}
