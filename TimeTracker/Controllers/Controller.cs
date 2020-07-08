using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Controllers
{
    // This class is being inherited by all Controllers
    // Is used to save info that all controllers will use
    public class Controller
    {
        public string db_name = "time_tracker";
    }
}
