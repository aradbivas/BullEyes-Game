using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A22_Ex05
{
    public partial class ChooseSizeForm : Form
    {
        private static int s_NumberOfChances = 4;

        public ChooseSizeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public int NumberOfChances
        {
            get
            {
                return s_NumberOfChances;
            }
        }

        private void buttonNumberOfChances_Click(object i_Sender, EventArgs i_Event)
        {
            StringBuilder buttonText = new StringBuilder();

            s_NumberOfChances++;
            if(s_NumberOfChances >= 11)
            {
                s_NumberOfChances = 4;
            }

            buttonText.Append("Number Of Chances: ");
            buttonText.Append(s_NumberOfChances.ToString());
            buttonNumberOfChances.Text = buttonText.ToString();
        }

        private void buttonStart_Click(object i_Sender, EventArgs i_Event)
        {
            this.Close();
        }
    }
}
