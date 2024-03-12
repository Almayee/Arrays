using System.Diagnostics.Metrics;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 6, 9, 24, 16, 99 };
            //int min = arr[0];
            //for ( int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i] < min )
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine(min);


            //string[] arr = { "Almaye", "Aysu", "Inare" };
            //Console.Write("Deyeri daxil edin");
            //string soz = Console.ReadLine();
            //for (int i = soz.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(soz[i]);
            //}


            //string[] arr = { "Almaye", "Aysu", "Inare" };
            //string[] tersArr = new string[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    tersArr[i] = arr[arr.Length - 1 - i];
            //}
            //for (int i = 0; i < tersArr.Length; i++)
            //{
            //    Console.WriteLine(tersArr[i]);
            //}



            int[] arr = { -6, 7, 9, -11 };
            int[] musbetArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    musbetArr[i] = -arr[i];
                }
                else
                {
                    musbetArr[i] = arr[i];
                }
            }
            for (int i = musbetArr.Length - 1; i >= 0; i--)
            {
                Console.Write(musbetArr[i]);
            }


             


        }
    }
}
