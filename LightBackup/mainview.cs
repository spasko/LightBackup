using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/////               "             ,

namespace WebBackup
{
    public partial class mainview : Form
    {
        public mainview()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            editService add = new editService();
            add.ShowDialog();





        }

        private void Form1_Load(object sender, EventArgs e) {
            Logger.connectConsole( info );
            Logger.toConsole("Witaj w programie WebBackup 0.01 Beta");
        }

        private void connections_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
