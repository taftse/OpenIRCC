using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIRCClient
{
    public partial class NickNameDialog : Form
    {
        private MainWindow parent;
        public NickNameDialog(MainWindow parent)
        {
            this.parent = parent;
            InitializeComponent();
            
        }

        private void nickOKbutton_Click(object sender, EventArgs e)
        {
            this.changeNick();
        }

        private void nick_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.changeNick();
            }
        }

        private void changeNick()
        {
            this.parent.ircClient.NickName = (string)nickNameTextBox.Text.ToString();
            this.Close();
        }
    }
}
