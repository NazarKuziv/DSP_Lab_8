using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab_8
{
    internal class FileViewer
    {
        private int n = 0;
        private int m = 0;

        public int GetM() { return this.m; }
        public int GetN() { return this.n; }
        public FileViewer() { n = 0; m = 0; }

        public int[,] ReadFile()
        {
            string line;
            string[] substr;
            int[,] fileInfo = null;

            StreamReader streamReader = new StreamReader("..\\..\\graf\\graph_01_1.txt");
            line = streamReader.ReadLine();
            substr = line.Split();
            this.n = Convert.ToInt32(substr[0]);
            this.m = Convert.ToInt32(substr[1]);

            fileInfo = new int[m + 1, 2];
            line = streamReader.ReadLine();
            for (int i = 1; line != null; i++)
            {
                substr = line.Split();
                fileInfo[i, 0] = Convert.ToInt32(substr[0]);
                fileInfo[i, 1] = Convert.ToInt32(substr[1]);
                line = streamReader.ReadLine();
            }
            streamReader.Close();

            return fileInfo;
        }

    }
}
