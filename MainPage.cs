using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_App_ESO_Tracker.BAL;

namespace WinForm_App_ESO_Tracker
{
    public partial class MainPage : Form
    {
        //Intialize classes.
        static SystemCheck status = new SystemCheck();

        //Form variables.
        

        public MainPage()
        {
            InitializeComponent();

            //Adjust form properties as needed.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Form methods.
        private void MainPage_Load(object sender, EventArgs e)
        {
            dbStatus.Text = status.Load
        }
    }
}
