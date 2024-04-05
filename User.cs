using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1B_gayaoyj_hms
{
    public class User
    {
        public string Name { get; set; }
        private string Address { get; set; }
        private string Email { get; set; }
        private string PhoneNumber { get; set; }
        public Account Account { get; set; }

        public User(string name, string address, string email, string phoneNumber, Account account)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            Account = account;
        }
        }
    }
