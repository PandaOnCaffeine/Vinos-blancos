namespace Vinos_blancos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I create a new int array with 11 elements
            int[] vinArr = new int[11] { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };

            //I add 35432 as the assignment says
            vinArr[5] = vinArr[5] + 35432;
            
            //a formula 
            const int max = 188052;
            const byte maxStars = 100;
            int star = 0;

            //I sort and then reverse the vinArr so that it is sorted in a decending order
            Array.Sort(vinArr);
            Array.Reverse(vinArr);

            //a for loop to print out the stars
            for (int i = 0; i < vinArr.Length; i++)
            {
                star = maxStars * vinArr[i] / max;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}