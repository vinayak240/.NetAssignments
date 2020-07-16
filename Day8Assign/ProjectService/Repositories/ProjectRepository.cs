using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectService.Models;

namespace ProjectService.Repositories
{
    public class ProjectRepository
    {
        public static employeedbContext repo = new employeedbContext();

        public IEnumerable<Projects> getAll()
        {
            return repo.Projects.ToList();
        }

        public Projects getById(string pid)
        {
            return repo.Projects.Find(pid);
        }

        public void addProject(Projects p)
        {
            repo.Projects.Add(p);
            repo.SaveChanges();
        }

        public void updateProject(Projects p)
        {
            repo.Projects.Update(p);
            repo.SaveChanges();
        }

        public void deleteProject(string pid)
        {
            Projects p = repo.Projects.Find(pid);

            repo.Projects.Remove(p);
            repo.SaveChanges();
        }
    }
}
