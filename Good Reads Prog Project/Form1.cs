using System.IO;
using System;

namespace Good_Reads_Prog_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                int ipBookId = functions.numberGenerator.GenerateRandomNumber(functions.dbRead.dbIdMax("bookTable", "bookId"));

                string ipBookTitle = functions.dbRead.ReadDB("bookTable", "bookId", ipBookId, "bookTitle");

                string authorIdStr = functions.dbRead.ReadDB("bookTable", "bookId", ipBookId, "bookAuthor");
                string ipAuthorName = null;
                if (int.TryParse(authorIdStr, out int authorId))
                {
                    ipAuthorName = functions.dbRead.ReadDB("authorTable", "authorId", authorId, "authorName");
                }

                if (string.IsNullOrWhiteSpace(ipBookTitle)) ipBookTitle = "(Title unavailable)";
                if (string.IsNullOrWhiteSpace(ipAuthorName)) ipAuthorName = "(Author unavailable)";

                byte[] imageData = functions.dbRead.ReadImageBytesDB("bookTable", "bookId", ipBookId, "bookCoverImg");
                Image ipBookImg = null;

                if (imageData != null && imageData.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(imageData))
                        using (var tempImg = Image.FromStream(ms))
                        {
                            ipBookImg = new Bitmap(tempImg);
                        }
                    }
                    catch (ArgumentException)
                        ipBookImg = null;
                    }
                    catch (Exception)
                    {
                        ipBookImg = null;
                    }
                }

                Control[] upperLabel = this.Controls.Find($"ULA_IP_{i}", true);
                if (upperLabel.Length > 0)
                {
                    upperLabel[0].Text = ipBookTitle;
                }

                Control[] lowerLabel = this.Controls.Find($"DLA_IP_{i}", true);
                if (lowerLabel.Length > 0)
                {
                    lowerLabel[0].Text = ipAuthorName;
                }

                Control[] BookImage = this.Controls.Find($"ULA_PB_{i}", true);
                if (BookImage.Length > 0)
                {
                    PictureBox pb = BookImage[0] as PictureBox;
                    if (pb != null)
                    {
                        pb.Image = ipBookImg;
                    }
                }
            }
        }
    }
}