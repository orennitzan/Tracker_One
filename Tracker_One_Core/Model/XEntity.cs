using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker_One_Core
{
    /// <summary>
    /// This is the object that holds all data of an individual entitiy on the board
    /// </summary>
    public class XEntity
    {
        public string entity_ID { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// The entity shape color (red, green, blue)
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// The entity shape (circle, square, triangle)
        /// </summary>
        public string Shape { get; set; }
        /// <summary>
        /// small, medium, large
        /// </summary>
        public string Size { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public string DisplayName
        {
            get
            {
                return string.Format("eID{0}_{1}", entity_ID.ToString(), Name);
            }
        }
    }
}
