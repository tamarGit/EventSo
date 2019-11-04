using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convert
{
    public class ConvertTask
    {
        public static Task ConvertTaskToDal(TaskDTO taskDTO)
        {
            return new Task
            {
                TaskCode=taskDTO.TaskCode,
                TaskName=taskDTO.TaskName,
                TaskStatus=taskDTO.TaskStatus,
                DeadLine=taskDTO.DeadLine,
                BeginingTime=taskDTO.BeginingTime,
                EventCode=taskDTO.EventCode,
                EventTypeCode=taskDTO.EventTypeCode,
                ProfessionalCode=taskDTO.ProfessionalCode
            };
        }
        public static TaskDTO ConvertTaskToDTO(Task taskDal)
        {
            return new TaskDTO
            {
                TaskCode=taskDal.TaskCode,
                TaskName=taskDal.TaskName,
                TaskStatus=taskDal.TaskStatus,
                DeadLine=taskDal.DeadLine,
                BeginingTime=taskDal.BeginingTime,
                EventCode=taskDal.EventCode,
                EventTypeCode=taskDal.EventTypeCode,
                ProfessionalCode=taskDal.ProfessionalCode
            };
        }
        public static List<TaskDTO> ConvertTaskListToDTO(List<Task> tasks)
        {
            return tasks.Select(t=> ConvertTaskToDTO(t)).ToList();
        }
    }
}
