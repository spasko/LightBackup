using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBackup {
    public partial class editService : Form {
        public editService() {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e) {
            Service ser = new Service();
            if (name.TextLength == 0) {
                MessageBox.Show("Wprowadź nazwę");
            }

            ser.name = name.Text;

            try {
                ServiceManager.getDefault().addService(ser);
                this.Close();
            } catch( MessageException ex ) {
                MessageBox.Show(ex.Message);
            }
            

            
       }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

      
    }
}
