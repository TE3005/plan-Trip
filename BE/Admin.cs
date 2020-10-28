using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Admin : User
    {
        private string phoneNumber;

        public Admin()
        {
        }

        public string PhoneNumber { get; set; }

        /// <summary>
        /// @param Admin 
        /// @return
        /// </summary>
        public void addAdmin(Admin admin)
        {
            // TODO implement here
        }

    }
}

