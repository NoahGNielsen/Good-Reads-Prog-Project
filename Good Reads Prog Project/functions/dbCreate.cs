using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Good_Reads_Prog_Project.functions
{
    internal class dbCreate
    {
        public static bool InitializeDatabase()
        {
            //opretter tabellerne

            Config config = new Config();
            string connectionString = config.DBAccessString;

            string sqlScript = @"
                -- 1. Create authorTable
                IF OBJECT_ID(N'dbo.authorTable', N'U') IS NULL
                BEGIN
                    CREATE TABLE [dbo].[authorTable](
                        [authorId] [INT] IDENTITY(1,1) NOT NULL,
                        [authorName] [VARCHAR](50) NOT NULL,
                        [authoredBooks] [VARCHAR](400) NULL,
                        CONSTRAINT [PK_authorTable] PRIMARY KEY CLUSTERED ([authorId] ASC)
                    );
                END;

                -- 2. Create bookTable
                IF OBJECT_ID(N'dbo.bookTable', N'U') IS NULL
                BEGIN
                    CREATE TABLE [dbo].[bookTable](
                        [bookId] [int] IDENTITY(1,1) NOT NULL,
                        [bookName] [VARCHAR](50) NOT NULL,
                        [bookDescription] [VARCHAR](255) NOT NULL,
                        [bookAuthor] [INT] NOT NULL,
                        [bookCoverImg] [IMAGE] NULL,
                        [bookUserReviews] [VARCHAR](MAX) NULL,
                        [bookAvgReviewScore] [INT] NULL,
                        [userReads] [VARCHAR](MAX) NULL,
                        CONSTRAINT [PK_bookTable] PRIMARY KEY CLUSTERED ([bookId] ASC),
                        CONSTRAINT [FK_bookTable_authorTable] FOREIGN KEY ([bookAuthor]) REFERENCES [dbo].[authorTable] ([authorId])
                    );
                END;

                -- 3. Create userTable
                IF OBJECT_ID(N'dbo.userTable', N'U') IS NULL
                BEGIN
                    CREATE TABLE [dbo].[userTable](
                        [userId] [INT] IDENTITY(1,1) NOT NULL,
                        [userName] [VARCHAR](50) NOT NULL,
                        [userHaveRead] [VARCHAR](MAX) NULL,
                        [userToBeRead] [VARCHAR](MAX) NULL,
                        [userReadingInProgress] [VARCHAR](MAX) NULL,
                        CONSTRAINT [PK_userTable] PRIMARY KEY CLUSTERED ([userId] ASC)
                    );
                END;
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlScript, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}