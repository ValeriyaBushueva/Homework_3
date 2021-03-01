using System;

namespace Homework_3
{
    // Бушуева Валерия
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = " Программа 1. Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;";
            CComplex.Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            CComplex.Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Console.WriteLine("Рассмотрим результат работы структуры:");
            CComplex.Complex result = complex1.Plus(complex2);
            Console.WriteLine("Результом операции сложения чисел: " + complex1.ToString() + " и " +
                              complex2.ToString() + " является "
                              + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Результом операции умножения чисел: " + complex1.ToString() + " и " +
                              complex2.ToString() + " является "
                              + result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine("Результом операции вычитания чисел: " + complex1.ToString() + " и " +
                              complex2.ToString() + " является "
                              + result.ToString());

            Console.WriteLine();

            Console.WriteLine("Рассмотрим результат работы класса:");
            CComplex ccomplex1 = new CComplex(1, 1);
            CComplex ccomplex2 = new CComplex(2, 2);
            ccomplex2.Im = 3;
            CComplex cresult = ccomplex1.Plus(ccomplex2);
            Console.WriteLine("Результом операции сложения чисел: " + ccomplex1.ToString() + " и " +
                              ccomplex2.ToString() + " является "
                              + cresult.ToString());
            cresult = ccomplex1.Multi(ccomplex2);
            Console.WriteLine("Результом операции умножения чисел: " + ccomplex1.ToString() + " и " +
                              ccomplex2.ToString() + " является "
                              + cresult.ToString());
            cresult = ccomplex1.Minus(ccomplex2);
            Console.WriteLine("Результом операции вычитания чисел: " + ccomplex1.ToString() + " и " +
                              ccomplex2.ToString() + " является "
                              + cresult.ToString());

            Console.ReadKey();

            Console.Clear();

            
            //-----------------------------------------NEXT TASK

            #region Task2

            Console.Title =
                " Программа 2. Подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse";

            static int CheckExeptionByInput()
            {
                int result = 0;
                bool exceptionCatched;
                do
                {
                    exceptionCatched = false;
                    try
                    {
                        result = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        exceptionCatched = true;
                        string message = ex.Message;
                        Console.WriteLine(message +
                                          "Неверный ввод (требуется числовое значение)\nПожалуйста, повторите ввод:");
                    }
                } while (exceptionCatched);

                return result;
            }

            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int AmountOfOddNumbers = 0;
            while (true)
            {
                int number = CheckExeptionByInput();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    AmountOfOddNumbers++;
                }
            }

            Console.WriteLine("Количество чисел: " + AmountOfOddNumbers);

            Console.ReadKey();
            Console.Clear();

            #endregion

        }
    }

    #region Task1

    // Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
    public class CComplex
    {
        private double im;
        double re;

        public CComplex()
        {
            im = 0;
            re = 0;
        }

        public CComplex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }

        public CComplex Plus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public CComplex Minus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        public CComplex Multi(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }

        public struct Complex
        {
            public double im;
            public double re;


            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }

            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }
    }
    #endregion
}



    


