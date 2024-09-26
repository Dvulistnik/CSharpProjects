using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class customTextbox : UserControl
    {
        public customTextbox()
        {
            InitializeComponent();
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;

            if (textBox1.Focused)
            {
                y -= 2;
                label1.Location = new Point(label1.Location.X, y);

                if (y <= 0)
                {
                    labelTimer.Stop();
                    label1.Font = new Font("Segoe UI", 8);
                    y = 0;
                    label1.ForeColor = Color.Silver;
                }
            }
            else
            {
                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 22)
                {
                    labelTimer.Stop();
                    label1.Font = new Font("Segoe UI", 10);
                    y = 22;
                    label1.ForeColor = Color.Black;
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }
    }
}
