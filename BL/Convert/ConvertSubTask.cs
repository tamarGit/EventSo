using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convert
{
    class ConvertSubTask
    {
        public static SubTask ConvertSubTaskToDal(SubTaskDTO subTaskDTO)
        {
            return new SubTask
            {
                SubTaskCode = subTaskDTO.SubTaskCode,
                SubTaskName=subTaskDTO.SubTaskName,
                SubTaskDate=subTaskDTO.SubTaskDate,
                TaskCode = subTaskDTO.TaskCode,
                BeginingTime=subTaskDTO.BeginingTime,
                status=subTaskDTO.status,
                details=subTaskDTO.details,
                duration=subTaskDTO.duration               
                
            };
        }
        public static SubTaskDTO ConvertSubTaskToDTO(SubTask subTaskDal)
        {
            return new SubTaskDTO
            {
                SubTaskCode=subTaskDal.SubTaskCode,
                SubTaskName=subTaskDal.SubTaskName,
                SubTaskDate=subTaskDal.SubTaskDate,
                TaskCode=subTaskDal.TaskCode,
                BeginingTime=subTaskDal.BeginingTime,
                status=subTaskDal.status,
                 details=subTaskDal.details,
                 duration=subTaskDal.duration,
                 
                 
            };

        }
        public static List<SubTaskDTO> ConvertSubTaskListToDTO(List<SubTask> subtasks)
        {
            return subtasks.Select(t => ConvertSubTaskToDTO(t)).ToList();
        }
    }
}
