using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Tiva Rait
 * Created on: 16-02-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program lets you select two different pictures of a cat
 * from a menu and allows you to close the program from the menu
*/
namespace MovingCatTivaR
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        //To close program
        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Displays cat image one
        private void mniCat1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }

        //Displays cat image two
        private void mniCat2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }
    }
}
