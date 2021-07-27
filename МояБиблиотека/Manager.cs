using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МояБиблиотека
{
    class Manager
    {
        private List<Project> projects = new List<Project>();

        public void AddProject(Project project)
        {
            projects.Add(project);
        }

        public Project GetProject(int index)
        {
            return projects[index];
        }

        public void RemoveProject(int index)
        {
            projects.RemoveAt(index);
        }

        public void RemoveProject(Project project)
        {
            projects.Remove(project);
        }

        public Project[] GetProjects()
        {
            return projects.ToArray();
        }

        public bool IsEmpty()
        {
            return projects.Count == 0;
        }
    }
}
