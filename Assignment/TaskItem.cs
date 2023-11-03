using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Assignment
{
    internal class TaskItem
    {
        public TaskItem(int taskId, string? taskDescription, bool isCompleted)
        {
            TaskId = taskId;
            TaskDescription = taskDescription;
            IsCompleted = isCompleted;
        }
        public TaskItem() { }
        public int TaskId { get; set; }
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; }


       public void AddTask(List<TaskItem> task)
        {
            Console.WriteLine("Added to the list");
            Console.WriteLine();
            foreach (TaskItem item in task)
            {
                Console.WriteLine("Task Id: " + item.TaskId + " Task Description: " + item.TaskDescription);
            }
            Console.WriteLine();
            
            
        }
        public void RemoveTask(int taskId,List<TaskItem>t)
        {
            TaskItem result = t.Find(x=>taskId == x.TaskId);

            if (result != null)
                {
                    t.Remove(result);
                    Console.WriteLine("Task "+taskId+" removed from the List");

                }
                else
                {
                    Console.WriteLine("Task with id " + taskId+"  doesn't exist");
                }
            
           
            
            
        }

    }
}
