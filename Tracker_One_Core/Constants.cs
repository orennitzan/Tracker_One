using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker_One_Core
{
    public static class Constants
    {
        // Ofsets to locate entity titles
        public const float offsetX_s = 15f;
        public const float offsetY_s = 15f;
        public const float offsetX_m = 19f;
        public const float offsetY_m = 17f;
        public const float offsetX_l = 22f;
        public const float offsetY_l = 17f;

        public const float boardTop = 30f;
        public const float boardLeft = 230f;
        public const float boardSize = 500f;

        // factor is the board pixel size / board business size (100)
        public const float factor = boardSize / 100;
    }
}
