using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondHomework
{
    public partial class AdditionalTask1 : Form
    {
        Panel panel;

        private bool isInRectangle;
        private bool onRectangleBorder;

        private int mouseX;
        private int mouseY;

        private int panelX;
        private int panelY;
        public AdditionalTask1()
        {
            InitializeComponent();
        }

        private void AdditionalTask1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control)
            {
                Close();
            }
            mouseX = e.Location.X;
            mouseY = e.Location.Y;

            isInRectangle = mouseX > panelX && mouseX < panel2.Width + panelX && mouseY > panelY && mouseY < panel2.Height + panelY;
            onRectangleBorder = mouseX == panelX || mouseX == panel2.Width + panelX || mouseY == panelY || mouseY == panel2.Height + panelY;
            if (e.Button == MouseButtons.Left)
            {
                if (isInRectangle)
                {
                    MessageBox.Show("Текущая точка: внутри прямоугольника");
                }
                else if (onRectangleBorder)
                {
                    MessageBox.Show("Текущая точка: на границе прямоугольника");
                }
                else
                {
                    MessageBox.Show("Текущая точка: снаружи прямоугольника");
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("", $"Ширина = {Size.Width}, Высота = {Size.Height}");
            }
        }

        private void AdditionalTask1_Load(object sender, EventArgs e)
        {
            panelX = panel2.Location.X;
            panelY = panel2.Location.Y;
        }

        private void AdditionalTask1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X = {e.X}, Y = {e.Y}";
        }
    }
}
