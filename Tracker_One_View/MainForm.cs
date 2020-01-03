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

namespace Tracker_One_View
{
    public partial class frmMain : Form
    {
        BoardMgr mgr = null;
        public frmMain()
        {
            InitializeComponent();
            mgr = new BoardMgr();
            mgr.BoardInit();
            

            SetHisStepsDefaults();
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


    }
}
