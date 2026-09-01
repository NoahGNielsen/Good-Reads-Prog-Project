using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;
namespace Good_Reads_Prog_Project
{
    public partial class Form2 : Form
    {
        SqlConnection conn;

        public Form2()
        {
            InitializeComponent();

            Config config = new Config();

            conn = new SqlConnection(config.DBAccessString);
            conn.Open();
        }

        private void tilføjToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minSideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minSideToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //ændre til form1 og fjerne form2
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTilføjBog_Click(object sender, EventArgs e)
        {
            string bookName = textBoxNavn.Text;
            string bookDescription = textBoxOm.Text;
            string bookAuthor = textBoxForfatter.Text;

            //Finder forfatterens id ud fra forfatterens navn
            string authorSQL = "SELECT authorId FROM authorTable WHERE authorName = '" + bookAuthor + "'";
            SqlCommand authorCommand = new SqlCommand(authorSQL, conn);
            object result = authorCommand.ExecuteScalar();

            int authorId = Convert.ToInt32(result);

            //opretter bogen
            string sSQL = "INSERT INTO bookTable (bookname, bookDescription, bookAuthor) " +
                "VALUES ('" + bookName + " ', ' " + bookDescription + " ', " + authorId + ");";
            SqlCommand command = new SqlCommand(sSQL, conn);
            command.ExecuteNonQuery();
        }

        private void buttonTilføjBogAnmeldelse_Click(object sender, EventArgs e)
        {
            int bookAvgReviewScore = Convert.ToInt32(textBoxRating.Text);
            string bookUserReviews = textBoxAnmeldelse.Text;
            string bookName = textBoxAnmeldelseNavn.Text;

            //updater den valgtes bog rating og anmeldelse
            string sSQL = "UPDATE BookTable SET bookAvgReviewScore= " + bookAvgReviewScore + ", bookUserReviews = ' " + bookUserReviews + " ' WHERE bookName = '" + bookName + "'";
            SqlCommand command = new SqlCommand(sSQL, conn);
            command.ExecuteNonQuery();
        }
    }
}
