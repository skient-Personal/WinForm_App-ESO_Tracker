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
using WinForm_App_ESO_Tracker.PAL;

namespace WinForm_App_ESO_Tracker
{
    public partial class MainPage : Form
    {
        //Intialize classes.
        CoreFunctions core = new CoreFunctions();

        //Form variables.
        
        public MainPage()
        {
            InitializeComponent();

            //Adjust form properties as needed.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Event methods.
        private void MainPage_Load(object sender, EventArgs e)
        {
        }
        private void MainPage_Shown(object sender, EventArgs e)
        {
            dbStatus.Text = core.System_Check();

            Load_Character();
        }

        //Form methods.
        private void Load_Character()
        {
            if (core.currentChar == "")
            {
                Form f = new PAL.aFile.SelectCharacter();
                f.Show();
            }
        }

        //ToolBar Methods
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new PAL.zHelp.AboutBox();
            f.Show();
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new PAL.yTools.Options();
            f.Show();
        }
    }
}
