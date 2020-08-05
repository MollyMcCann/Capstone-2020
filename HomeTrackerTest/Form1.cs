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

            var homeCollection = new HomeCollection();
          
            using (HomeTrackerModel1 db = new HomeTrackerModel1())//move this to form load
            {
                //retrieve data:
                Home home = (from h in db.Homes
                             select h).FirstOrDefault();
                homeCollection.Add(home);
            }
        
            foreach( Home home in homeCollection)
            {
                //searchBox.Text = home.Address; ADD THIS BACK EVENTUALLY, THIS WAS THE TEST TO SEE IF WE CAN CONNECT to db
                
            }
        }
        private PeopleCollection1 peopleCollection;
        private RealEstateCompanyCollection realEstateCompanyCollection;
        private HomeCollection homeCollection;
        private HomeSalesCollection homeSalesCollection;
        // group varibles together do this with all collections
        //this is where you will have all the reach from db to ui and the code paths
        private void AddressListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddressListBox.Text = home.Address;
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
