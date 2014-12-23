using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;


namespace Numbers
{
    public class RunNumbers : Runner
    {
        public RunNumbers()
        {
            new FindPiToTheNthDigit(this);

            PickAndRunProjects();
        }
    }
}
