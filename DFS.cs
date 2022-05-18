using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab_8
{
    internal class DFS
    {
        string[,] mat = null;
        int n = 0;
        public string[,] Search(Adjacency AdjacencyMat, int[,] matrix, int point)
        {
            Stack<int> Stack = new Stack<int>();
            Dictionary<int, int> Dictionary = new Dictionary<int, int>();

            this.n = AdjacencyMat.GetN();

            String[,] Table = new string[n * 2 + 1, 3];

            Dictionary.Add(point, 1);
            Stack.Push(point);

            Table[1, 0] = Stack.Peek().ToString();
            Table[1, 1] = 1.ToString();
            string joinedString = String.Join(",", Stack);
            Table[1, 2] = joinedString;

            int DFCNum = 2;
            bool isFound = false;
            int pointer;

            for (int itr = 2; Stack.Count > 0; itr++)
            {
                pointer = Stack.Peek();
                isFound = false;
                for (int i = 1; i < n + 1; i++)
                {
                    if (matrix[pointer, i] == 1 && pointer != i)
                    {
                        if (!Dictionary.ContainsKey(i))
                        {
                            Dictionary.Add(i, DFCNum);
                            Stack.Push(i);

                            Table[itr, 0] = i.ToString();
                            Table[itr, 1] = DFCNum.ToString();
                            DFCNum++;
                            isFound = true;
                            break;
                        }
                    }
                }
                if (!isFound)
                {
                    Table[itr, 0] = "-";
                    Table[itr, 1] = "-";
                    Stack.Pop();
                }
                joinedString = String.Join(",", Stack);
                Table[itr, 2] = joinedString;
            }
            this.mat = Table;
            return Table;
        }
        public void PrintResult()
        {
            for (int i = 1; i < this.n * 2 + 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{this.mat[i, j],20}");
                }
                Console.WriteLine();
            }
        }
    }
}
