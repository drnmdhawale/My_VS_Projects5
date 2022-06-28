using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HappyBirthday birthdayMessage = new HappyBirthday();;
            string returnedMessage;

            birthdayMessage.MyProperty = "Shahid";
            returnedMessage = birthdayMessage.MyProperty;
            
            MessageBox.Show(returnedMessage);
        }
    }
}
