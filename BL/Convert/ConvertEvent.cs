﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
   public class ConvertEvent
    {
        public static Event ConvertEventToDAL(EventDTO event1)
        {
            return new Event
            {
                EventCode = event1.EventCode,
                EventDate = event1.EventDate,
                EventName = event1.EventName,
                EventStatus = event1.EventStatus,
                //EventTypeCode=event1.EventTypeCode,
                UserCode = event1.UserCode,
                EventTypeCode = eventTypeBL.GetCodeByName(event1.EventTypeName)

            };
        }

        public static EventDTO ConvertEventToDTO(Event event1)
        {
            return new EventDTO
            {
                EventCode = event1.EventCode,
                UserCode = event1.UserCode,
                EventTypeName = event1.EventTypeCode,
            };
        }
        public static List<EventDTO> ConvertEventListToDTO(List<Event> events)
        {
            return events.Select(e => ConvertEventToDTO(e)).ToList();
        }




    }
}