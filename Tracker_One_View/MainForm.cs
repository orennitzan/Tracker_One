using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracker_One_Core;
using Tracker_One_Core.Model;

namespace Tracker_One_View
{
    public partial class frmMain : Form
    {
        private BoardMgr mgr = null;

        // Ofsets to locate entity titles
        private const float offsetX_s = 15f;
        private const float offsetY_s = 15f;
        private const float offsetX_m = 19f;
        private const float offsetY_m = 17f;
        private const float offsetX_l = 22f;
        private const float offsetY_l = 17f;

        private const float boardTop = 30f;
        private const float boardLeft = 230f;
        private const float boardSize = 500f;

        // factor is the board pixel size / board business size (100)
        private const float factor = boardSize / 100;


        public frmMain()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            mgr = new BoardMgr();
            mgr.BoardInit();
            SetHisStepsDefaults();
            LoadCheckBoxList();

        }

        /// <summary>
        /// Try to get min and max values out of configurations and set the values to the numeric up down control. The defaults will be 1 and 5. 
        /// </summary>
        private void SetHisStepsDefaults()
        {
            var minSteps = mgr.GetMinHisStepsValueFromConfig();
            numUpDwn.Minimum = minSteps;
            numUpDwn.Value = minSteps;
            numUpDwn.Maximum = mgr.GetMaxHisStepsValueFromConfig();

        }

        private void LoadCheckBoxList()
        {
            var y = chkBxList.Location.Y - 30;
            foreach (var item in mgr.GetEntitiesDisplayList())
            {
                var chk = new CheckBox();
                chk.Name = item.Id;
                chk.Text = item.DisplayName;
                chk.Location = new Point(chkBxList.Location.X, y += 30);
                chk.Checked = true;
                chk.Click += CheckBox_Clicked;
                chkBxList.Controls.Add(chk);
            }


        }

        private void CheckBox_Clicked(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            var isVisiable = chk.Checked;
            var eId = chk.Name;
            // TODO show hide relevet uc
            var ex = mgr.GetEntitiesList().Where(q => q.entity_ID == eId).FirstOrDefault();
            ex.IsVisiable = isVisiable;
            // Cause the form to redraw and as an outcome to onpaint to be called
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawBoard(g);
            base.OnPaint(e);

        }

        private void DrawBoard(Graphics g)
        {
            DrawBoardBackground(g);

            var eList = mgr.GetEntitiesList();
            //DrawBoardEntity(g, eList.First());

            foreach (var xe in eList)
            {
                DrawBoardEntity(g, xe);
            }
        }

        private void DrawBoardBackground(Graphics g)
        {
            SolidBrush br = new SolidBrush(Color.FromArgb(226, 226, 250));
            g.FillRectangle(br, boardLeft, boardTop, boardSize, boardSize);
        }

        private void DrawBoardEntity(Graphics g, XEntity xe)
        {
            if (!xe.IsVisiable) return;
            // Entity Size
            int size = HelperMethods.GetEntitySize(xe.Size);

            // Center location of the shape

            // Set x to relative to board's x
            float x = xe.X * factor + boardLeft;

            // Set y to be relative to board's botom y
            float y = boardTop + boardSize - xe.Y * factor - size;

            // Brush
            var brush = HelperMethods.GetSolidBrush(xe.Color);
            // Shape
            EntityShape shape = HelperMethods.GetEntityShape(xe.Shape);

            // Draw Shape
            switch (shape)
            {
                case EntityShape.circle:
                    g.FillEllipse(brush, x, y, size, size);
                    break;
                case EntityShape.square:
                    g.FillRectangle(brush, x, y, size, size);
                    break;
                case EntityShape.triangle:
                    Point[] pArr = HelperMethods.GetTrianglePointsArray((int)x, (int)y, size);
                    g.FillPolygon(brush, pArr);
                    break;
            }

            DrawEntityTitle(g, xe, x, y);

        }

        private void DrawEntityTitle(Graphics g, XEntity xe, float x, float y)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            float offsetX = 0;
            float offsetY = 0;
            var size = HelperMethods.GetEntityEnumSize(xe.Size);
            switch (size)
            {
                case EntitySize.small:
                    offsetX = offsetX_s;
                    offsetY = offsetY_s;
                    break;
                case EntitySize.medium:
                    offsetX = offsetX_m;
                    offsetY = offsetY_m;
                    break;
                case EntitySize.large:
                    offsetX = offsetX_l;
                    offsetY = offsetY_l;
                    break;
            }

            // Draw string to screen.
            g.DrawString(xe.DisplayId, drawFont, drawBrush, x - offsetX, y - offsetY);

        }

    }
}
