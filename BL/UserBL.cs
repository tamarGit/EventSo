using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using BL.Convert;

namespace BL
{
    public class UserBL
    {
        public EventSoDBEntities1 DB = new EventSoDBEntities1();
        public UserDTO LogIn(string mail, string password)
        {
            User user = DB.Users.FirstOrDefault(p => p.Password == password && p.Mail == mail);
            if (user != null)
            {
                return ConvertUser.convertUserToDTO(user);
            }
            return null;
        }
        //public List<EventDTO> GetEvents(string mail, string password)
        //{

        //}
    }
}
