using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User : IUser
    {

        private string userName;

        private string firstName;

        private string lastName;

        private string password;

        private string userMail;

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserMail { get; set; }


        public User()
        {

        }


        public string GetMailAddress()
        {
            // To Do
            return null;

        }
        public string GetFirstName()
        {
            // To Do
            return null;
        }
        public string GetLastName()
        {
            // To Do
            return null;
        }
        public string GetPassword()
        {
            // To Do
            return null;
        }
        public void setPassword(string oldPassword, string newPassword)
        {

        }
        

    }
}
