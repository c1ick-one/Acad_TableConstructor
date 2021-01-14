using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace Acad_TableConstructor
{
    class Information
    {
        public string[][] GetFromCSV(string pathCsvFile)
        {

           
            StreamReader sr = new StreamReader(pathCsvFile);
            var lines = new List<string[]>();
            int Row = 0;
            while (!sr.EndOfStream)
            {
                string[] Line = sr.ReadLine().Split(',');
                lines.Add(Line);
                Row++;
                Console.WriteLine(Row);
            }

           string [][] data = lines.ToArray();

            return data;
        }
        public string[,] GetInformation()
        {
            string[,] str = new string[5, 3];
            str[0, 0] = "Part No.";
            str[0, 1] = "Name ";
            str[0, 2] = "Material ";
            str[1, 0] = "1876-1";
            str[1, 1] = "Flange";
            str[1, 2] = "Perspex";
            str[2, 0] = "0985-4";
            str[2, 1] = "Bolt";
            str[2, 2] = "Steel";
            str[3, 0] = "3476-K";
            str[3, 1] = "Tile";
            str[3, 2] = "Ceramic";
            str[4, 0] = "8734-3";
            str[4, 1] = "Kean";
            str[4, 2] = "Mostly water";
            return str;
        }
    }
}
