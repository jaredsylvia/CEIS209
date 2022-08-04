using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5
{

    public partial class mainForm : Form
    {
        class InfoForMessageBox
        {
            public string titleText { get; set; }
            public string messageText { get; set; }
            public bool isOkayButton { get; set; }
            

        }
        public mainForm()
        {
            InitializeComponent();
        }

        private void showMessageBox_Click(object sender, EventArgs e)
        {
            InfoForMessageBox infoForMessageBox = new InfoForMessageBox
            {
                titleText = messageBoxTitleText.Text,
                messageText = messageBoxMessageText.Text,
                isOkayButton = radioButtonTrue.Checked
            };
            if(infoForMessageBox.isOkayButton == true){
                MessageBox.Show(infoForMessageBox.messageText, infoForMessageBox.titleText, MessageBoxButtons.OK);
            }
            else if (infoForMessageBox.isOkayButton == false)
            {
                MessageBox.Show(infoForMessageBox.messageText, infoForMessageBox.titleText, MessageBoxButtons.YesNo);
            }

        }

        private void messageBoxButtonLabel_Click(object sender, EventArgs e)
        {

        }
    }
    
}
