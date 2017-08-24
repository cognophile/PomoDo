using System.Windows.Forms;

namespace PomoDo
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPomoDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(67, 54);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(152, 19);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to PomoDo";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(82, 221);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(118, 13);
            this.lbl_author.TabIndex = 1;
            this.lbl_author.Text = "Authored by Cognophile";
            
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "PomoDo has been minimized to the system tray. To interact with it, double click t" +
    "o open or right-click to access the menu.";
            this.notifyIcon.BalloonTipTitle = "PomoDo";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PomoDo - Pomodoro Assistant";
            // Event Handlers
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconMouseDoubleClickOpenApplication);
            this.notifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NotifyIconRightClickOpenMenu);
            
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPomoDoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(154, 70);
            
            // 
            // openPomoDoToolStripMenuItem
            // 
            this.openPomoDoToolStripMenuItem.Name = "openPomoDoToolStripMenuItem";
            this.openPomoDoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openPomoDoToolStripMenuItem.Text = "Open PomoDo";
            // Event Handlers
            this.openPomoDoToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NotifyIconMouseDoubleClickOpenApplication);
            
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // Event Handlers
            this.quitToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NotifyIconRightClickMenuQuitApplication);
            
            // 
            // Dashboard Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "PomoDo";
            this.Resize += new System.EventHandler(this.TrayMinimizeFormResize);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_author;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem openPomoDoToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}

