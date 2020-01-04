﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

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

        public string DisplayId
        {
            get
            {
                return string.Format("eID{0}", entity_ID.ToString());
            }
        }

        public bool IsVisiable { get; set; }

        public Point PrevPoint { get; set; }

        public List<Point> HistoryTrack { get; set; }

        public XEntity()
        {
            
            IsVisiable = true;
            // Init the hitory track and populate the current point. By default we want to remember at least one point.
            HistoryTrack = new List<Point>();
            HistoryTrack.Add(new Point(X, Y));

            PrevPoint = new Point(-999, -999);
        }
    }

    public struct XDisplayEntity
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        // TOOD add DisplayTitle Here
    }
}
