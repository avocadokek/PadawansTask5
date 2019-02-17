using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            string s = "";
            int i;
            int j;
            int k = 0;
            for (i = 0, j = source.Length - 1; i < source.Length / 2; i++, j--)
            {
                if (source[i] == source[j])  // если элементы равны увеличиваем счётчик
                    k++;
            }
            if (k == source.Length / 2)
            { s = "Yes"; }
            else { s = "No"; }
            return s;
            throw new NotImplementedException();

        }


        public static void Main()
        {
            link1:
            Console.WriteLine("Enter number of elements: \n");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] mas = new int[n];
                Random rand = new Random();



                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rand.Next(0, 2);
                    Console.WriteLine(mas[i]);
                }

                var res = CheckIfSymmetric(mas);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter a positive integer number!");
                goto link1;
            }

        }
    }
}
