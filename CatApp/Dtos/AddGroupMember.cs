namespace ChatApp.Dtos
{
    public class AddGroupMember
    {
        public int GroupID { get; set; }
        public string UserName { get; set; }

        public bool IsAdmin { get; set; }
    }
}
