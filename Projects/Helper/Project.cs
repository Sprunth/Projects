using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    /// <summary>
    /// An individual project pertaining to a specific entry listed in the repo
    /// </summary>
    public abstract class Project
    {
        public string ProjectName { get; private set; }

        protected Project(string projectName, Runner parentRunner)
        {
            ProjectName = projectName;
            parentRunner.AddProject(this);
        }

        public abstract void Run();
    }
}
