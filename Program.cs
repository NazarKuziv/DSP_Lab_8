using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FileViewer file = new FileViewer();
            int[,] graf = file.ReadFile();
            Adjacency AdjacencyMat = new Adjacency();


            DFS dfs = new DFS();
            dfs.Search(AdjacencyMat, AdjacencyMat.CreateMatrix(file, graf), 1);
            Console.WriteLine(" Обхід графа пошуком углиб:\n");
            dfs.PrintResult();
        }
    }
}
