using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface IUser
    {

        /// <summary>
        /// @return
        /// </summary>
        string GetMailAddress();

        /// <summary>
        /// @return
        /// </summary>
        string GetFirstName();

        /// <summary>
        /// @return
        /// </summary>
        string GetLastName();

        /// <summary>
        /// @return
        /// </summary>
        string GetPassword();

        /// <summary>
        /// @param old 
        /// @param new 
        /// @return
        /// </summary>
        void setPassword(string oldPassword, string newPassword);

}
}
