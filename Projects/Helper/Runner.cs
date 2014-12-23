using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    /// <summary>
    /// Runs "Project"s
    /// </summary>
    public abstract class Runner
    {
        private readonly Dictionary<int, Tuple<String, Action>> Projects = new Dictionary<int, Tuple<string, Action>>();

        public void AddProject(Project p)
        {
            Projects.Add(Projects.Count,new Tuple<string, Action>(p.ProjectName, p.Run));
        }

        public void PickAndRunProjects()
        {
            int result;
            while (true)
            {
                foreach (var key in Projects.Keys)
                {
                    Console.WriteLine("{0}: {1}", key, Projects[key].Item1);
                }
                if (int.TryParse(Console.ReadLine(), out result) && result >= 0 && result < Projects.Count)
                    break;;
            }

            Projects[result].Item2.Invoke();
            
        }
    }
}
