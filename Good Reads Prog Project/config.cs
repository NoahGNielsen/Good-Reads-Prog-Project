using System;
using System.Collections.Generic;
using System.Text;

namespace Good_Reads_Prog_Project
{
    public class Config
    {
        // opretter forbindelse til database
        public readonly string DBAccessString = @"Data Source=localhost\sqlexpress;Initial Catalog=GoodBooks;Integrated Security=True;TrustServerCertificate=True";
        public readonly bool devMode = true;

    }
}

/*
 * Noah: @"Data Source=LAPTOP-M65QG9A2\SQLEXPRESS01;Initial Catalog=goodBooksDB;Integrated Security=True;TrustServerCertificate=True";
 * Emilia: @"Data SourceData Source=localhost\sqlexpress;Initial Catalog=GoodBooks;Integrated Security=True;TrustServerCertificate=True";
 * Elias:
 */