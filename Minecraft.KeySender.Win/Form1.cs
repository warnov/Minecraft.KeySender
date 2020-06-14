using System;
using System.Threading;
using System.Windows.Forms;

namespace Minecraft.KeySender.Win
{
    public partial class Form1 : Form
    {
        readonly string _commandTemplate = "/fill {0} {1} {2} {3} {4} {5} sandstone_stairs 3";
        int x1 = 294, y1 = 63, z1 = 162, x2 = 344, y2 = 63, z2 = 162;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            Thread.Sleep(5000);

            for (int i = 0; i < 25; i++)
            {
                x1++;
                y1++;
                z1--;
                x2--;
                y2++;
                z2--;
                var command = String.Format(_commandTemplate, x1, y1, z1, x2, y2, z2);                
                SendKeys.Send("{ENTER}");
                Thread.Sleep(2000);
                SendKeys.Send(command);
                Thread.Sleep(1800);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(2000);
            }
        }
    }
}
