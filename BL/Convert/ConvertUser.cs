using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convert
{
    class ConvertUser
    {
        public static User convertUserToDAL(UserDTO user1)
        {
            return new User
            {
                Clue = user1.Clue,
                Mail = user1.Mail,
                Password = user1.Password,
                Phone = user1.Phone,
                UserName = user1.UserName
            };
        }

        public static UserDTO convertUserToDTO(User user1)
        {
            return new UserDTO
            {
                Clue = user1.Clue,
                Mail = user1.Mail,
                Password = user1.Password,
                Phone = user1.Phone,
                UserName = user1.UserName
            };
        }
    }
}
