using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomoDo
{
    public partial class Dashboard : Form
    {
        public Dashboard() => InitializeComponent();

        private void TrayMinimizerForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void NotifyIcon_MouseDoubleClick_OpenApplication(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
            this.Show();
        }

        private void NotifyIcon_RightClick_OpenMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void NotifyIcon_RightClickMenu_Quit(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}