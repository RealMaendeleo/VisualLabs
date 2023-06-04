using System;

/*  
    Создать класс «Матрица 3х3» позволяющий вычислять сумму и
    произведение матриц, а также методы или свойства получения определителя
    матрицы и суммы элементов на главной и побочной диагонали
*/

namespace VisualLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix3x3 m1 = new Matrix3x3();
            m1.fill();
            
            Matrix3x3 m2 = new Matrix3x3();
            m2.fill();

            Matrix3x3 res_matrix = m1 + m2;
            Console.WriteLine("+\n");
            res_matrix.print();

            res_matrix.clear();
            res_matrix = m1 * m2;
            Console.WriteLine("\n*\n");
            res_matrix.print();

            Console.WriteLine("det(res) = " + res_matrix.Det);
            Console.WriteLine("mainDiagSum(res) = " + res_matrix.MainDiagSum);
            Console.WriteLine("sideDiagSum(res) = " + res_matrix.SideDiagSum);

            Console.Write("Press enter to close...");
            Console.ReadLine();
        }
    }
}