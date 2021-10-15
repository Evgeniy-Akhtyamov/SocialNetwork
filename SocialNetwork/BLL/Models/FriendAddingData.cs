using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    public class FriendAddingData
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public int Friend_id { get; set; }
        public string FriendEmail { get; set; }
    }
}
