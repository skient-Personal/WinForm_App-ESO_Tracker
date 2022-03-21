using System;
using System.Collections.Generic;
using System.Text;
using WinForm_App_ESO_Tracker.DAL;

namespace WinForm_App_ESO_Tracker.BAL
{
    public class CoreFunctions
    {
        //Class Variables.
        DBHelper db = new DBHelper();
        public esoDataSet eso = new esoDataSet();
        public string currentChar = "";

        //Class Constructors.
        public CoreFunctions() { }

        //Class Methods
        public string System_Check()
        {
            string status = "";

            eso = db.Connect_DB();
            if (eso == null) status = "Database Status: Database Failed To Connect!!!";
            else status = "Database Status: Database Connected...";

            //Check Load Character Menu
            if (Properties.Settings.Default["DefaultCharSet"] != null)
                currentChar = Properties.Settings.Default["DefaultCharSet"].ToString();

            return status;
        }

    }
}
