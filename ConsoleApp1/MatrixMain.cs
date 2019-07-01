using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week10.Classses;

namespace ConsoleApp1
{
    class MatrixMain
    {
        static void Main(string[] args)
        {
            Matrix<int> newMatrix = new Matrix<int>(3, 3);

            newMatrix[0, 0] = 1;
            newMatrix[0, 1] = 3;
            newMatrix[0, 2] = 5;

            newMatrix[1, 0] = 4;
            newMatrix[1, 1] = 6;
            newMatrix[1, 2] = 8;

            newMatrix[2, 0] = 7;
            newMatrix[2, 1] = 9;
            newMatrix[2, 2] = 11;

            newMatrix.PrintMatrix();

            Console.ReadKey();
                     
        }
    }
}
