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

                // Safely resolve author id and name
                string authorIdStr = functions.dbRead.ReadDB("bookTable", "bookId", ipBookId, "bookAuthor");
                string ipAuthorName = null;
                if (int.TryParse(authorIdStr, out int authorId))
                {
                    ipAuthorName = functions.dbRead.ReadDB("authorTable", "authorId", authorId, "authorName");
                }

                // Fallbacks for missing text data
                if (string.IsNullOrWhiteSpace(ipBookTitle)) ipBookTitle = "(Title unavailable)";
                if (string.IsNullOrWhiteSpace(ipAuthorName)) ipAuthorName = "(Author unavailable)";

                // 1. Fetch the raw bytes from the database
                byte[] imageData = functions.dbRead.ReadImageBytesDB("bookTable", "bookId", ipBookId, "bookCoverImg");
                Image ipBookImg = null;

                // 2. Convert the byte array into an Image using a MemoryStream
                if (imageData != null && imageData.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(imageData))
                        using (var tempImg = Image.FromStream(ms))
                        {
                            // Make a copy so we don't depend on the stream lifetime
                            ipBookImg = new Bitmap(tempImg);
                        }
                    }
                    catch (ArgumentException)
                    {
                        // invalid image bytes -> leave ipBookImg null or set placeholder
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