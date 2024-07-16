using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class ApplicationUser   : IdentityUser
    {
        //public int Id { get;set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        

      
        public virtual ICollection<ChatMessage> SentMessages { get; set; }
        public virtual ICollection<ChatMessage> ReceivedMessages { get; set; }
        public virtual ICollection<UserFriend> Friends { get; set; }
        public virtual ICollection<UserFriend> FriendOf { get; set; }
        public virtual ICollection<ChatGroup> OwnedGroups { get; set; }
        public virtual ICollection<ChatGroupMember> GroupMembers { get; set; }

    }
}
