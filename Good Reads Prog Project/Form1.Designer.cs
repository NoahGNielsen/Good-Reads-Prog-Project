namespace Good_Reads_Prog_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            minSideToolStripMenuItem = new ToolStripMenuItem();
            anbefalingerToolStripMenuItem = new ToolStripMenuItem();
            plusToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { minSideToolStripMenuItem, anbefalingerToolStripMenuItem, plusToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // minSideToolStripMenuItem
            // 
            minSideToolStripMenuItem.Name = "minSideToolStripMenuItem";
            minSideToolStripMenuItem.Size = new Size(79, 24);
            minSideToolStripMenuItem.Text = "Min side";
            // 
            // anbefalingerToolStripMenuItem
            // 
            anbefalingerToolStripMenuItem.Name = "anbefalingerToolStripMenuItem";
            anbefalingerToolStripMenuItem.Size = new Size(109, 24);
            anbefalingerToolStripMenuItem.Text = "Anbefalinger";
            // 
            // plusToolStripMenuItem
            // 
            plusToolStripMenuItem.Name = "plusToolStripMenuItem";
            plusToolStripMenuItem.Size = new Size(53, 24);
            plusToolStripMenuItem.Text = "Plus ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem minSideToolStripMenuItem;
        private ToolStripMenuItem anbefalingerToolStripMenuItem;
        private ToolStripMenuItem plusToolStripMenuItem;
    }
}
