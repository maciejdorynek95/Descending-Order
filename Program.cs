using System;

namespace Kata
{
    public class Kata
    {
        public static int DescendingOrder(int num)
        {
            #region zmienneLokalne
            var length = (int)(Math.Log10(num) + 1);
            char[] Numbers = new char[length];
            var i = 0;
            #endregion
            foreach (char ch in num.ToString())
            {
                Numbers[i] = ch;
                i++;
            }
            Array.Sort(Numbers);
            Array.Reverse(Numbers);

            //Assert
            var oczekiwana = 66653211;
            //Act
            var aktualna = Kata.DescendingOrder(11352666);
            //Assert
            Console.WriteLine($"Sprawdzenie: {Equals(oczekiwana, aktualna)}");

            return int.Parse(String.Join("", Numbers)); //łącz

           
        }
        public static void Main()
        {

        }
    }
}





