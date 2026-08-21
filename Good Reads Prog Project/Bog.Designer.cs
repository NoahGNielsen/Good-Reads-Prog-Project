namespace Good_Reads_Prog_Project
{
    partial class Bog
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
            label_bookName = new Label();
            label_bookAuthor = new Label();
            listBox_bookDescription = new ListBox();
            picBox_bookCover = new PictureBox();
            btn_addToMyPage = new Button();
            label_writtenBy = new Label();
            menuStrip1 = new MenuStrip();
            minSideToolStripMenuItem = new ToolStripMenuItem();
            anbefalingerToolStripMenuItem = new ToolStripMenuItem();
            plusToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picBox_bookCover).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label_bookName
            // 
            label_bookName.AutoSize = true;
            label_bookName.Font = new Font("Segoe UI", 15F);
            label_bookName.Location = new Point(410, 108);
            label_bookName.Name = "label_bookName";
            label_bookName.Size = new Size(358, 47);
            label_bookName.TabIndex = 0;
            label_bookName.Text = "PLACEHOLDER NAME";
            // 
            // label_bookAuthor
            // 
            label_bookAuthor.AutoSize = true;
            label_bookAuthor.Location = new Point(525, 165);
            label_bookAuthor.Name = "label_bookAuthor";
            label_bookAuthor.Size = new Size(221, 30);
            label_bookAuthor.TabIndex = 1;
            label_bookAuthor.Text = "PLACEHOLDER author";
            // 
            // listBox_bookDescription
            // 
            listBox_bookDescription.FormattingEnabled = true;
            listBox_bookDescription.Location = new Point(410, 208);
            listBox_bookDescription.Name = "listBox_bookDescription";
            listBox_bookDescription.Size = new Size(369, 274);
            listBox_bookDescription.TabIndex = 2;
            // 
            // picBox_bookCover
            // 
            picBox_bookCover.Location = new Point(45, 108);
            picBox_bookCover.Name = "picBox_bookCover";
            picBox_bookCover.Size = new Size(330, 495);
            picBox_bookCover.TabIndex = 3;
            picBox_bookCover.TabStop = false;
            // 
            // btn_addToMyPage
            // 
            btn_addToMyPage.Location = new Point(493, 546);
            btn_addToMyPage.Name = "btn_addToMyPage";
            btn_addToMyPage.Size = new Size(195, 57);
            btn_addToMyPage.TabIndex = 4;
            btn_addToMyPage.Text = "Tilføj til Min Side";
            btn_addToMyPage.UseVisualStyleBackColor = true;
            btn_addToMyPage.Click += btn_addToMyPage_Click;
            // 
            // label_writtenBy
            // 
            label_writtenBy.AutoSize = true;
            label_writtenBy.Location = new Point(410, 165);
            label_writtenBy.Name = "label_writtenBy";
            label_writtenBy.Size = new Size(109, 30);
            label_writtenBy.TabIndex = 5;
            label_writtenBy.Text = "Skrevet af:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { minSideToolStripMenuItem, anbefalingerToolStripMenuItem, plusToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(857, 40);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // minSideToolStripMenuItem
            // 
            minSideToolStripMenuItem.Name = "minSideToolStripMenuItem";
            minSideToolStripMenuItem.Size = new Size(110, 34);
            minSideToolStripMenuItem.Text = "Min side";
            // 
            // anbefalingerToolStripMenuItem
            // 
            anbefalingerToolStripMenuItem.Name = "anbefalingerToolStripMenuItem";
            anbefalingerToolStripMenuItem.Size = new Size(150, 34);
            anbefalingerToolStripMenuItem.Text = "Anbefalinger";
            // 
            // plusToolStripMenuItem
            // 
            plusToolStripMenuItem.Name = "plusToolStripMenuItem";
            plusToolStripMenuItem.Size = new Size(75, 34);
            plusToolStripMenuItem.Text = "Plus ";
            // 
            // Bog
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 703);
            Controls.Add(menuStrip1);
            Controls.Add(label_writtenBy);
            Controls.Add(btn_addToMyPage);
            Controls.Add(picBox_bookCover);
            Controls.Add(listBox_bookDescription);
            Controls.Add(label_bookAuthor);
            Controls.Add(label_bookName);
            Name = "Bog";
            Text = "Bog";
            ((System.ComponentModel.ISupportInitialize)picBox_bookCover).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_bookName;
        private Label label_bookAuthor;
        private ListBox listBox_bookDescription;
        private PictureBox picBox_bookCover;
        private Button btn_addToMyPage;
        private Label label_writtenBy;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem minSideToolStripMenuItem;
        private ToolStripMenuItem anbefalingerToolStripMenuItem;
        private ToolStripMenuItem plusToolStripMenuItem;
    }
}