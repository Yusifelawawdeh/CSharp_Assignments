using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    class ArrayPractice
    {
        public void FirstRealArray()
        {

            int[] lockCombination = new int[3] { 10, 2, 20 };
            var combo = lockCombination.Length;
            Console.Write(combo);
        }
    }

    class Cell
    {
        public string Contents { get; set; }

        public void JaggedArrayOne()
        {
            Cell[][] sheet = new Cell[100][];
            for (int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            {
                sheet[rowIndex] = new Cell[10];
                for (int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
                {
                    sheet[rowIndex][colIndex] = new Cell();
                }
            }
        }

        public void JaggedArrayTwo()
        {
            Cell[][] sheet = new Cell[100][];
            foreach (Cell[] row in sheet)
            {
                foreach (Cell cell in row)
                {
                    System.Console.Write(cell);
                }
            }
        }

        public void JaggedArrayThree()
        {
            Cell[][] sheet = new Cell[100][];
            foreach (Cell[] row in sheet)
            {

                foreach (Cell cell in row)
                {
                    Console.Write(cell);
                }

                Console.WriteLine();

            }
        }

        public void MultidimensionalArray()
        {
            Cell[,] sheet = new Cell[100, 10];
            for (int rowIndex = 0; rowIndex < sheet.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < sheet.GetLength(1); colIndex++)
                {
                    sheet[rowIndex, colIndex] = new Cell();
                }
            }
        }

        public void ThreeDimensionalMultidimensionalArray()
        {
            Cell[,,] sheet = new Cell[5, 5, 5];
            for (int widthIndex = 0; widthIndex < sheet.GetLength(0); widthIndex++)
            {
                for (int lengthIndex = 0; lengthIndex < sheet.GetLength(1); lengthIndex++)
                {
                    for (int heightIndex = 0; heightIndex < sheet.GetLength(2); heightIndex++)
                    {
                        sheet[widthIndex, lengthIndex, heightIndex] = new Cell();
                    }
                }
            }
        }

        public static int[,] BuildMultiplicationTable(int maxFactor)
        {
            int[,] multiplicationTable = new int[maxFactor + 1, maxFactor + 1];

            for (int x = 0; x < maxFactor + 1; x++)
            {

                for (int y = 0; y < maxFactor + 1; y++)
                {
                    multiplicationTable[x, y] = x * y;
                }

            }
            return multiplicationTable;
        }

        public void CopyPastaArray()
        {
            int[] ages = { 24, 34, 56 };

            int[] agesCopy = new int[4];

            ages.CopyTo(agesCopy, 1);

            agesCopy[0] = 16;

            Console.Write(agesCopy);
        }

        public void Matrix()
        {
            int[,] matrix = new int[5, 5];
        }

        public void ThreeDimensionalJaggedArray()
        {
            //Cell[][][] sheet = new Cell[100][][];

            //foreach (Cell width in sheet)
            //{

            //    foreach (Cell length in width)
            //    {
            //        foreach (Cell height in sheet)
            //        {   
            //            Console.Write(cell); 
            //        }
            //    }

            //    Console.WriteLine();

            //}

        }
    }
}
