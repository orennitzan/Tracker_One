using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker_One_Core.Model;

namespace Tracker_One_Core
{
    public class HelperMethods
    {
        private static Random rnd = new Random();

        public static string GetFilePath(string fileName)
        {
            return Path.Combine(Environment.CurrentDirectory, fileName);
        }

        public static Color GetEntityColor(EntityColor color)
        {
            Color c = Color.Red;
            switch (color)
            {
                case EntityColor.red:
                    c = Color.Red;
                    break;
                case EntityColor.green:
                    c = Color.Green;
                    break;
                case EntityColor.blue:
                    c = Color.Blue;
                    break;

            }
            return c;
        }

        public static SolidBrush GetSolidBrush(string color)
        {
            EntityColor ec = EntityColor.red;
            Enum.TryParse<EntityColor>(color, out ec);
            if ((int)ec == 0) ec = EntityColor.red;
            Color c = GetEntityColor(ec);
            SolidBrush br = new SolidBrush(c);
            return br;
        }

        public static EntitySize GetEntityEnumSize(string size)
        {
            // Default size - medium.
            EntitySize es = EntitySize.medium;
            Enum.TryParse<EntitySize>(size, out es);
            if ((int)es == 0) es = EntitySize.medium;
            return es;
        }

        public static int GetEntitySize(string size)
        {
            // Default size - medium.
            EntitySize es = EntitySize.medium;
            Enum.TryParse<EntitySize>(size, out es);
            if ((int)es == 0) es = EntitySize.medium;
            return Convert.ToInt32(es);
        }

        public static EntityShape GetEntityShape(string shape)
        {
            // Default shape - square.
            EntityShape es = EntityShape.square;
            Enum.TryParse<EntityShape>(shape, out es);
            if ((int)es == 0) es = EntityShape.square;
            return es;
        }

        public static Point[] GetTrianglePointsArray(int x, int y, int size)
        {
            Point[] arr = new Point[3];
            int h = CalcTriangleHeight(size);
            var pLeft = new Point(x, y + h);
            var pRight = new Point(x + size, y + h);

            int half = size / 2;
            var pTop = new Point(x + half, y);

            arr[0] = pLeft;
            arr[1] = pRight;
            arr[2] = pTop;

            return arr;

        }

        private static int CalcTriangleHeight(int size)
        {
            // Calculate the hight
            // Let a be the hight lets call it h!!
            // Let b be the base (half of size)
            // Let c be the size (the triangle edge).
            var half = size / 2;
            var b = half;
            var bPow = Math.Pow(Convert.ToDouble(b), 2);
            var cPow = Math.Pow(Convert.ToDouble(size), 2);
            return (int)Math.Sqrt(cPow - bPow);
        }

        internal static MovementDirection GetRandomDirection(XEntity xe)
        {
            int r = rnd.Next(1, 5);
            var dir = (MovementDirection)r;
            return dir;
        }
    }
}
