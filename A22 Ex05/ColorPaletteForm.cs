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
    public partial class ColorPaletteForm : Form
    {
        private static bool s_IsClosedByColor = false;
        private static Color s_Color;

        public ColorPaletteForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public Color ButtonColor
        {
            get
            {
                return s_Color;
            }
        }

        public bool IsClosedByColor
        {
            get
            {
                return s_IsClosedByColor;
            }

            set
            {
                s_IsClosedByColor = value;
            }
        }

        private void Button_Click(object i_Sender, System.EventArgs i_Event)
        {
            Button colorButton = i_Sender as Button;

            s_Color = colorButton.BackColor;
            s_IsClosedByColor = true;
            this.Close();
        }
    }
}
