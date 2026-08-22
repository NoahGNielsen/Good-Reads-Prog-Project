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
            listBox_In_Progress = new ListBox();
            label_In_Progress = new Label();
            label_TBR = new Label();
            listBox_TBR = new ListBox();
            label_Read = new Label();
            listBox_Read = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { minSideToolStripMenuItem, anbefalingerToolStripMenuItem, plusToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1200, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // minSideToolStripMenuItem
            // 
            minSideToolStripMenuItem.Name = "minSideToolStripMenuItem";
            minSideToolStripMenuItem.Size = new Size(110, 34);
            minSideToolStripMenuItem.Text = "Min side";
            minSideToolStripMenuItem.Click += minSideToolStripMenuItem_Click;
            // 
            // anbefalingerToolStripMenuItem
            // 
            anbefalingerToolStripMenuItem.Name = "anbefalingerToolStripMenuItem";
            anbefalingerToolStripMenuItem.Size = new Size(150, 34);
            anbefalingerToolStripMenuItem.Text = "Anbefalinger";
            anbefalingerToolStripMenuItem.Click += anbefalingerToolStripMenuItem_Click;
            // 
            // plusToolStripMenuItem
            // 
            plusToolStripMenuItem.Name = "plusToolStripMenuItem";
            plusToolStripMenuItem.Size = new Size(75, 34);
            plusToolStripMenuItem.Text = "Plus ";
            plusToolStripMenuItem.Click += plusToolStripMenuItem_Click;
            // 
            // listBox_In_Progress
            // 
            listBox_In_Progress.FormattingEnabled = true;
            listBox_In_Progress.Location = new Point(18, 102);
            listBox_In_Progress.Margin = new Padding(4, 4, 4, 4);
            listBox_In_Progress.Name = "listBox_In_Progress";
            listBox_In_Progress.Size = new Size(1150, 154);
            listBox_In_Progress.TabIndex = 1;
            listBox_In_Progress.SelectedIndexChanged += listBox_In_Progress_SelectedIndexChanged;
            // 
            // label_In_Progress
            // 
            label_In_Progress.AutoSize = true;
            label_In_Progress.Location = new Point(18, 68);
            label_In_Progress.Margin = new Padding(4, 0, 4, 0);
            label_In_Progress.Name = "label_In_Progress";
            label_In_Progress.Size = new Size(122, 30);
            label_In_Progress.TabIndex = 2;
            label_In_Progress.Text = "In progress ";
            label_In_Progress.Click += label_In_Progress_Click;
            // 
            // label_TBR
            // 
            label_TBR.AutoSize = true;
            label_TBR.Location = new Point(18, 262);
            label_TBR.Margin = new Padding(4, 0, 4, 0);
            label_TBR.Name = "label_TBR";
            label_TBR.Size = new Size(49, 30);
            label_TBR.TabIndex = 3;
            label_TBR.Text = "TBR";
            label_TBR.Click += label_TBR_Click;
            // 
            // listBox_TBR
            // 
            listBox_TBR.FormattingEnabled = true;
            listBox_TBR.Location = new Point(18, 297);
            listBox_TBR.Margin = new Padding(4, 4, 4, 4);
            listBox_TBR.Name = "listBox_TBR";
            listBox_TBR.Size = new Size(1150, 154);
            listBox_TBR.TabIndex = 4;
            listBox_TBR.SelectedIndexChanged += listBox_TBR_SelectedIndexChanged;
            // 
            // label_Read
            // 
            label_Read.AutoSize = true;
            label_Read.Location = new Point(18, 458);
            label_Read.Margin = new Padding(4, 0, 4, 0);
            label_Read.Name = "label_Read";
            label_Read.Size = new Size(59, 30);
            label_Read.TabIndex = 5;
            label_Read.Text = "Read";
            label_Read.Click += label_Read_Click;
            // 
            // listBox_Read
            // 
            listBox_Read.FormattingEnabled = true;
            listBox_Read.Location = new Point(18, 492);
            listBox_Read.Margin = new Padding(4, 4, 4, 4);
            listBox_Read.Name = "listBox_Read";
            listBox_Read.Size = new Size(1150, 154);
            listBox_Read.TabIndex = 6;
            listBox_Read.SelectedIndexChanged += listBox_Read_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 675);
            Controls.Add(listBox_Read);
            Controls.Add(label_Read);
            Controls.Add(listBox_TBR);
            Controls.Add(label_TBR);
            Controls.Add(label_In_Progress);
            Controls.Add(listBox_In_Progress);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
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
        private ListBox listBox_In_Progress;
        private Label label_In_Progress;
        private Label label_TBR;
        private ListBox listBox_TBR;
        private Label label_Read;
        private ListBox listBox_Read;
    }
}
