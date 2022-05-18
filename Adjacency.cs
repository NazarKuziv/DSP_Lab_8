using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab_8
{
    internal class Adjacency
    {
        private int[,] matrix = null;
        private int n = 0;
        private int m = 0;
        public int GetM() { return this.m; }
        public int GetN() { return this.n; }
        public int[,] GetMatrix() { return this.matrix; }
        public int[,] CreateMatrix(FileViewer file, int[,] matrix)
        {
            this.n = file.GetN();
            this.m = file.GetM();

            int[] N = FillN(this.n);

            int[,] M = new int[this.n + 1, this.n + 1];

            bool isEqual = false;
            for (int i = 1; i < this.n + 1; i++)
            {
                for (int j = 1; j < this.n + 1; j++)
                {
                    isEqual = false;
                    int[] V = { N[i], N[j] };
                    for (int k = 1; k < m + 1; k++)
                    {
                        if ((V[0] == matrix[k, 0]) && (V[1] == matrix[k, 1]))
                        {
                            isEqual = true;
                            break;
                        }
                    }
                    if (isEqual)
                    {
                        M[i, j] = 1;
                    }
                    else
                    {
                        M[i, j] = 0;
                    }
                }
            }
            this.matrix = matrix;
            return M;
        }
        public int[] FillN(int n)
        {
            int[] N = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                N[i] = i;
            }
            return N;
        }

    }
}
