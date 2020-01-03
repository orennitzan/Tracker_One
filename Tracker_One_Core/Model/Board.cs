using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker_One_Core.Access;

namespace Tracker_One_Core
{
    /// <summary>
    /// Holds tha data of existing entities
    /// </summary>
    public class Board
    {
        public List<XEntity> Entities { get; set; }
        public int HisNumberOfSteps { get; set; }

        public Board()
        {
            Entities = new List<XEntity>();
            HisNumberOfSteps = 1;
        }

        
        
    }
}
