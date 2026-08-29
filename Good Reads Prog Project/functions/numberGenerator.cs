using System;
using System.Collections.Generic;
using System.Text;

namespace Good_Reads_Prog_Project.functions
{
    internal class numberGenerator
    {
        public static int GenerateRandomNumber(int max)
        {
            Random random = new Random();
            return random.Next(1, max);
        }
    }
}
