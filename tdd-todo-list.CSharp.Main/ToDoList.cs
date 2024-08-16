using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using taskList;


namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        
        private List<TaskObj> _tasks = new List<TaskObj>();
        
        public bool Add(TaskObj task) {
            _tasks.Add(task);
            return true;
        }

     
        public bool ChangeStatus(TaskObj task) { 
            task.TaskStatus = true;
            return true;
        }
        public List<TaskObj> AllCompletedTasks { get { return _tasks.Where(t => t.TaskStatus == true).ToList<TaskObj>(); } }

        //Another way ->
        /*public List<TaskObj> OnlyCompleteTasks(List<TaskObj> tasks) {
            tasks.ForEach(task => task.TaskStatus = true);
            return tasks;
        }*/
        public List<TaskObj> AllInCompletedTasks { get { return _tasks.Where(t => t.TaskStatus == false).ToList<TaskObj>(); } }
        //Another way ->
        //public List<TaskObj> OnlyIncompleteTasks(List<TaskObj> tasks) { 
          //  return tasks.Where(t => t.TaskStatus == false).ToList<TaskObj>();
        //}
        public List<TaskObj> AllTasks {  get { return _tasks; } }
        
        public string SearchForTask(TaskObj task)
        {
            string msg = "";
            foreach (TaskObj taskObj in _tasks) {
                if (task == taskObj)
                {
                    msg = "Task exist in the list";
                }
                else { 
                    msg = "Task doesnt exist in the list";
                }
            }

            return msg;
        }
        public int removeTask(TaskObj task) { 
            _tasks.Remove(task);
            return _tasks.Count;
        }

        public List<TaskObj> Ascend(List<TaskObj> _tasks) { 
            List<TaskObj> list1 = new List<TaskObj>(_tasks);
            list1.Sort();
            return list1;
        }
        public List<TaskObj> Descend(List<TaskObj> _tasks)
        {
            List<TaskObj> list1 = new List<TaskObj>(_tasks);
            list1.Sort((x, y) => string.Compare(y.TaskName, x.TaskName)); 
            return list1;
        }

    }
}