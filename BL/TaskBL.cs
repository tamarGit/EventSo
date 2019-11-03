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

        public int CreateTask(TaskDTO taskDTO)
        {
            return  DB.Tasks.Add(BL.Convert.ConvertTask.ConvertTaskToDal(taskDTO)).TaskCode;
        }
        public List<TaskDTO> GetTasks(int eventCode)
        {
            return BL.Convert.ConvertTask.ConvertTaskListToDTO(DB.Tasks.Where(t => eventCode == t.EventCode).ToList());
        }
        public int CreateSubTask(SubTaskDTO subTaskDTO)
        {
            return DB.SubTasks.Add(BL.Convert.ConvertSubTask.ConvertSubTaskToDal(subTaskDTO)).SubTaskCode;
        }
        public List<SubTaskDTO> GetSubTasks(int taskCode)
        {
            return BL.Convert.ConvertSubTask.ConvertSubTaskListToDTO(DB.SubTasks.Where(st => st.TaskCode == taskCode).ToList());
        }
    }
}
