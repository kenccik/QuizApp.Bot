using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Bot.Models
{
    public class UserModel
    {
        public long Id { get; set; }    

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? UserName { get; set; }

        public string? Phone { get; set; }

        public bool isBot { get; set; }
    }
}
