using System;

namespace VisualLab2
{
    class Matrix3x3
    {
        internal int[,] array;
        int det;
        int mainDiagSum;
        int sideDiagSum;

        public int Det
        {
            get
            {
                int res = 0;
                for (int i = 0; i < 3; i++)
                    res = res + (this.array[0, i] * (this.array[1, (i + 1) % 3] * this.array[2, (i + 2) % 3]
                                                    - this.array[1, (i + 2) % 3] * this.array[2, (i + 1) % 3]));
                return det;
            }
        }

        public int MainDiagSum
        {
            get
            {
                int res = 0;
                for (int i = 0; i < 3; i++)
                    res += this.array[i, i];
                return res;
            }
        }

        public int SideDiagSum
        {
            get
            {
                int res = 0;
                for (int i = 0; i < 3; i++)
                    res += this.array[i, 2 - i];
                return res;
            }
        }

        public Matrix3x3()
        {
            array = new int[3, 3];
        }

        public object this[int i, int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = Convert.ToInt32(value); }
        }

        public void fill()
        {
            Console.WriteLine("Fill the matrix, please");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    int item;
                    Console.Write("matrix[{0}][{1}] = ", i+1, j+1);
                    string input = Console.ReadLine();
                    bool isInt = int.TryParse(input, out item);
                    while (!isInt)
                    {
                        Console.WriteLine("\n*** Input correct number ***\n");
                        Console.Write("matrix[{0}][{1}] = ", i+1, j+1);
                        input = Console.ReadLine();
                        isInt = int.TryParse(input, out item);
                    }
                    array[i, j] = item;
                }
            }
            Console.WriteLine();
            this.print();
        }

        public void clear()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this[i, j] = 0;
                }
            }
        }

        public void print()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(this[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static Matrix3x3 operator +(Matrix3x3 m1, Matrix3x3 m2)
        {
            Matrix3x3 temp_matrix = new Matrix3x3();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp_matrix[i, j] = m1.array[i, j] + m2.array[j, i];
                }
            }
            return temp_matrix;
        }

        public static Matrix3x3 operator *(Matrix3x3 m1, Matrix3x3 m2)
        {
            Matrix3x3 temp_matrix = new Matrix3x3();
            int item = 0;
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        item += m1.array[k, j] * m2.array[j, i];
                    }
                    temp_matrix[k, i] = item;
                    item = 0;
                }
            }
            return temp_matrix;
        }
    }
}
