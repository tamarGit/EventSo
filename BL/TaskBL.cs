using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BL.Convert;
using DAL;

namespace BL
{
    public class TaskBL
    {
        public EventSoDBEntities1 DB = new EventSoDBEntities1();

        public int AddTask(TaskDTO taskDTO)
        {
            Task taskDal=BL.Convert.
        }
    }
}
