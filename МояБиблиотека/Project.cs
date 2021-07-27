using System.Collections.Generic;

namespace МояБиблиотека
{
    public class Project : Common
    {       
        private List<Task> tasks;

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public Task GetTask(int index)
        {
            return tasks[index];
        }

        public Task[] GetTasks()
        {
            return tasks.ToArray();
        }

        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }  

        public override string ToString()
        {
            return $"Проект: {GetName()}, примечание: {GetNotice()}";
        }
    }
}
