using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BL.Convert;

namespace BL
{
    public class EventBl
    {
        public EventSoDBEntities1 DB = new EventSoDBEntities1();
        public List<EventDTO> GetEvents(int code,int status)
        {
            if(status==1)
                return BL.Convert.ConvertEvent.ConvertEventListToDTO(DB.Events.Where(eventDal => eventDal.UserCode == code && eventDal.EventStatus == 1).ToList());
            if(status == 2)
                return BL.Convert.ConvertEvent.ConvertEventListToDTO (DB.Events.Where(eventDal => eventDal.UserCode == code&&eventDal.EventStatus==2).ToList());            
            return BL.Convert.ConvertEvent.ConvertEventListToDTO(DB.Events.Where(eventDal => eventDal.UserCode == code && eventDal.EventStatus == 3).ToList());

        }
        public int CreateEvent(EventDTO eventDTO)
        {
            Event eventDAL = BL.Convert.ConvertEvent.ConvertEventToDAL(eventDTO);
            int code=DB.Events.Add(eventDAL).EventCode;
            try
            {
                DB.SaveChanges();
                return code;
            }catch(Exception ) { 
            return -1;}
        }
    }
}
