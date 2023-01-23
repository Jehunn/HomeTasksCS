using System;

namespace HomeTaskCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.WriteLine("Yazini daxil et : ");
            //string sentence = Console.ReadLine();
            //var result = FirstLetter(sentence);
            //Console.WriteLine($"Ilk soz : {result}");
            #endregion




            #region Task2
            //Console.WriteLine("Yazini daxil edin :");
            //string sentence2 = Console.ReadLine();
            //var result2 = numWord(sentence2);
            //Console.WriteLine($"Sozlerin sayi : {result2}");
            #endregion




            #region Task3
            //int[] arrNumbers = { -19, 90, -75, 14, 5, -9, -65, 57, -29 };
            //var result3 = PositiveNums(arrNumbers);
            //Console.WriteLine("Musbet ededler :");
            //foreach (var number in result3)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion




            #region Task4
            //string[] nmm = { "HK41","SLR047","AR15","SR1","QR","HR" };
            //var result5 = WantedNumInStr(nmm);
            //Console.WriteLine($"{result5} yazida reqem var");
            #endregion




            #region Task5
            //Console.WriteLine("Yazini daxil edin :");
            //string  sentence6=Console.ReadLine();
            //var result6=indexOfStr(sentence6);
            //Console.WriteLine($"Ilk bosluq {result6}");
            #endregion




            #region Task6
            Console.WriteLine("Yazi daxil edin : ");
            string sentence7 = Console.ReadLine();
            var result7 = NoLeftSpace(sentence7);
            Console.WriteLine($"Yazida ilk boslugu olmayan index : {result7}");
            #endregion



          ----------------------------------------------------------------------------------------



            #region Verilmis reqemler listinde verilmis reqemin olub olmamasini yoxlayan
            int[] numbers1 = { 22, 57, 16, -28, -61, 76, -12 };
            Console.WriteLine("Axtarmaq istediyiniz reqemi daxil edin: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNumber(numbers1, number1));
            #endregion



            #region Verilmis reqemler listindeki reqemlerin verilmis reqemler llistinde olub olmamasini yoxlayan
            int[] nums = { 90, 65, 85, 220, 12, 32, 13, -21 };
            int[] num = { 90, -12, 32 };
            Console.WriteLine(HasNumbers(nums, num));
            #endregion



            #region Verilmis charin reqem olub olmadigini yoxlayan
            Console.WriteLine(HasChar('4'));
            #endregion



            #region Verilmis yazinin icinde verilmis charin hansi indexde oldugunu gosderen program
            Console.WriteLine(IndexNumber("Rasulov", 'l'));
            #endregion



            #region Verilmis yazida verilmis indekse qeder olan yazini yazdiran program
            Console.WriteLine(HalfWord("Ceyhun", 4));
            #endregion









        }

        #region Task1
        //static string FirstLetter(string word)
        //{
        //    string newStr = "";
        //    for (int i=0; i<word.Length; i++)
        //    {
        //        if (word[i] != ' ')
        //        {
        //            newStr += word[i];
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    return newStr;        
        //}
        #endregion




        #region Task2
        // static int numWord(string str)
        //{
        //     int count = 1;
        //     for (int i=0; i<str.Length;i++)
        //     {
        //         if (str[i]==' ')
        //         {
        //             count++;
        //         }
        //     }
        //     return count;
        //}
        #endregion




        #region Task3
        //static int[] PositiveNums(int[] array)
        //{
        //    int count = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] > 0)
        //        {
        //            count++;
        //        }

        //    }
        //    int[] ArrPositive= new int[count];
        //    int ctr = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] > 0)
        //        {
        //            ArrPositive[ctr] = array[i];
        //            ctr++;
        //        }
        //    }
        //    return ArrPositive;
        //}
        #endregion




        #region Task5
        //static int indexOfStr(string[] str)
        //{
        //    int count = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (HasNumber(str[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion




        #region Task6
        //static int NoLeftSpace(string str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] != ' ')
        //        {
        //            return i;
        //            break;
        //        }
        //    }
        //    return -1;

        //}
        #endregion




        #region Task7
        //static string NoSpaceInLeft(string str)
        //{
        //    int count = 0;
        //    string newStr = "";
        //    for (int i=0;i<str.Length;i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            count++;
        //        }
        //        if (i >= count)
        //        {
        //            newStr += str[i];
        //        }
        //    }
        //    return newStr;
        //}
        #endregion









        //Verilmis reqemler listinde verilmis reqemin olub olmamasini yoxlayan metod
        static bool FindNumber(int[] arr, int wantedNumber)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == wantedNumber)
                {
                    return true;
                }
            }
            return false;
        }

        // Verilmis reqemler listindeki reqemlerin verilmis reqemler llistinde olub olmamasini yoxlayan metod 
        static bool HasNumbers(int[] arr, int[] arr2)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                if (FindNumber(arr2, arr[i]))
                {
                    return true;
                }

            }
            return false;
        }

        // Verilmis charin reqem olub olmadigini yoxlayan metod 
        static bool HasChar(char ch)
        {
            char[] cr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < cr.Length; i++)
            {
                if (ch == cr[i])
                {
                    return true;
                }
            }
            return false;



        }

        // Verilmis yazinin icinde verilmis charin hansi indexde oldugunu gosderen metod
        static int IndexNumber(string str, char cr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                {
                    return i;
                }
            }
            return -1;
        }

        // Verilmis yazida verilmis indekse qeder olan yazini yazdiran metod
        static string HalfWord(string word, int number)
        {
            string str = "";
            for (int i = 0; i < number; i++)
            {
                str += word[i];
            }
            return str;

        }
    }
}
