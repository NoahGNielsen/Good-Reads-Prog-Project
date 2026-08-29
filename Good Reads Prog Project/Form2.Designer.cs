namespace Good_Reads_Prog_Project
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            minSideToolStripMenuItem = new ToolStripMenuItem();
            tilføjToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            buttonTilføjBog = new Button();
            textBoxForfatter = new TextBox();
            textBoxOm = new TextBox();
            textBoxNavn = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            buttonTilføjBogAnmeldelse = new Button();
            textBoxAnmeldelse = new TextBox();
            textBoxRating = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            textBoxAnmeldelseNavn = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { minSideToolStripMenuItem, tilføjToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1147, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // minSideToolStripMenuItem
            // 
            minSideToolStripMenuItem.Name = "minSideToolStripMenuItem";
            minSideToolStripMenuItem.Size = new Size(126, 36);
            minSideToolStripMenuItem.Text = "Min side";
            minSideToolStripMenuItem.Click += minSideToolStripMenuItem_Click_1;
            // 
            // tilføjToolStripMenuItem
            // 
            tilføjToolStripMenuItem.Name = "tilføjToolStripMenuItem";
            tilføjToolStripMenuItem.Size = new Size(87, 36);
            tilføjToolStripMenuItem.Text = "Tilføj";
            tilføjToolStripMenuItem.Click += tilføjToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 63);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 1;
            label1.Text = "Navn på bog";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 125);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 2;
            label2.Text = "Om bogen";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonTilføjBog);
            panel1.Controls.Add(textBoxForfatter);
            panel1.Controls.Add(textBoxOm);
            panel1.Controls.Add(textBoxNavn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 329);
            panel1.TabIndex = 3;
            // 
            // buttonTilføjBog
            // 
            buttonTilføjBog.Location = new Point(462, 258);
            buttonTilføjBog.Name = "buttonTilføjBog";
            buttonTilføjBog.Size = new Size(150, 46);
            buttonTilføjBog.TabIndex = 8;
            buttonTilføjBog.Text = "Tilføj";
            buttonTilføjBog.UseVisualStyleBackColor = true;
            buttonTilføjBog.Click += buttonTilføjBog_Click;
            // 
            // textBoxForfatter
            // 
            textBoxForfatter.Location = new Point(188, 187);
            textBoxForfatter.Name = "textBoxForfatter";
            textBoxForfatter.Size = new Size(794, 39);
            textBoxForfatter.TabIndex = 7;
            // 
            // textBoxOm
            // 
            textBoxOm.Location = new Point(188, 125);
            textBoxOm.Name = "textBoxOm";
            textBoxOm.Size = new Size(794, 39);
            textBoxOm.TabIndex = 6;
            // 
            // textBoxNavn
            // 
            textBoxNavn.Location = new Point(188, 63);
            textBoxNavn.Name = "textBoxNavn";
            textBoxNavn.Size = new Size(794, 39);
            textBoxNavn.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 187);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 4;
            label4.Text = "Forfatter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 14);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 3;
            label3.Text = "Tilføj bog";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxAnmeldelseNavn);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(buttonTilføjBogAnmeldelse);
            panel2.Controls.Add(textBoxAnmeldelse);
            panel2.Controls.Add(textBoxRating);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(23, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(1096, 335);
            panel2.TabIndex = 4;
            // 
            // buttonTilføjBogAnmeldelse
            // 
            buttonTilføjBogAnmeldelse.Location = new Point(462, 256);
            buttonTilføjBogAnmeldelse.Name = "buttonTilføjBogAnmeldelse";
            buttonTilføjBogAnmeldelse.Size = new Size(150, 46);
            buttonTilføjBogAnmeldelse.TabIndex = 11;
            buttonTilføjBogAnmeldelse.Text = "Tilføj";
            buttonTilføjBogAnmeldelse.UseVisualStyleBackColor = true;
            buttonTilføjBogAnmeldelse.Click += buttonTilføjBogAnmeldelse_Click;
            // 
            // textBoxAnmeldelse
            // 
            textBoxAnmeldelse.Location = new Point(188, 189);
            textBoxAnmeldelse.Name = "textBoxAnmeldelse";
            textBoxAnmeldelse.Size = new Size(794, 39);
            textBoxAnmeldelse.TabIndex = 10;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(188, 135);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(794, 39);
            textBoxRating.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 20);
            label7.Name = "label7";
            label7.Size = new Size(230, 32);
            label7.TabIndex = 2;
            label7.Text = "Tilføj en anmeldelse";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 135);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 1;
            label6.Text = "Rating";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(139, 32);
            label5.TabIndex = 0;
            label5.Text = "Anmeldelse";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 83);
            label8.Name = "label8";
            label8.Size = new Size(152, 32);
            label8.TabIndex = 12;
            label8.Text = "Navn på bog";
            // 
            // textBoxAnmeldelseNavn
            // 
            textBoxAnmeldelseNavn.Location = new Point(188, 83);
            textBoxAnmeldelseNavn.Name = "textBoxAnmeldelseNavn";
            textBoxAnmeldelseNavn.Size = new Size(794, 39);
            textBoxAnmeldelseNavn.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 813);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem minSideToolStripMenuItem;
        private ToolStripMenuItem tilføjToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox textBoxForfatter;
        private TextBox textBoxOm;
        private TextBox textBoxNavn;
        private Label label4;
        private Button buttonTilføjBog;
        private Panel panel2;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button buttonTilføjBogAnmeldelse;
        private TextBox textBoxAnmeldelse;
        private TextBox textBoxRating;
        private TextBox textBoxAnmeldelseNavn;
        private Label label8;
    }
}