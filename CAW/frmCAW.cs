using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAW {
    public partial class frmCAW : Form {

        public frmCAW() {
            InitializeComponent();
        }

        private void lblCaw_Click(object sender, EventArgs e) {
            try {
                Close();

            } catch (Exception ex) {
                ShowMessage.ShowErrorMessage("System Error" + "\r" +
                                             "content：" + ex.Message + "\r" +
                                             "detail：" + ex.StackTrace);

            }
        }
    }   //--end class
}   //--end namespace
