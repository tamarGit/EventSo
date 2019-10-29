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
        public int LogIn(string mail, string password)
        {
            User user = DB.Users.FirstOrDefault(p => p.Password == password && p.Mail == mail);
            if (user != null)
            {
                return user.UserCode;
            }
            return 0;
        }
        public int SignIn(UserDTO userDTO)
        {
            User user= BL.Convert.ConvertUser.convertUserToDAL(userDTO);
            User checkUserExist=(DB.Users.FirstOrDefault(u => u.Mail == user.Mail));                       
            int c=  DB.Users.Add(user).UserCode;
            try
            {
                DB.SaveChanges();
                
                return c;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
