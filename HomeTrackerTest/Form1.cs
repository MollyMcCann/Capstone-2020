using HomeTrackerDatamodelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTrackerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            homeCollection = new HomeCollection();
            foreach( Home home in homeCollection)
            {
                searchBox.Text = home.Address;
            }
        }

       private HomeCollection homeCollection;// group varibles together do this with all collections
        //this is where you will have all the reach from db to ui and the code paths
        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
