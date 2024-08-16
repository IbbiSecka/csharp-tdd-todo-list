using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskList
{
    public class TaskObj : IComparable<TaskObj>
    {
        public string TaskName { get; set; }
        public bool TaskStatus { get; set; }

        public TaskObj(string taskName, bool taskStatus)
        {
            TaskName = taskName;
            TaskStatus = taskStatus;
        }
        public int CompareTo(TaskObj oneObj)
        {
            if (oneObj == null)
                return 1;

       
            return string.Compare(this.TaskName, oneObj.TaskName);
        }

    }
}

