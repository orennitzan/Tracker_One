using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracker_One_View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            List<string> chkList = new List<string>() { "aaa", "bbb", "ccc", "ddd", "eee" };

            ListBox.ObjectCollection col = new ListBox.ObjectCollection(chkBxList);
            
            //chkBxList.Items.Add()
        }


    }
}
