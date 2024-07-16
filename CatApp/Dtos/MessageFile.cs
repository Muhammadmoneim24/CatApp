namespace ChatApp.Dtos
{
    public class MessageFile
    {
        public string SenderId { get; set; }
        public string ReceiverId {  get; set; }
        
        public IFormFile? File { get; set; }
    }
}
