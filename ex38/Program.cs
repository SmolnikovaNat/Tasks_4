namespace HelloWorld
{
    class Program
    {
        //Задача 38. Задайте массив вещественных чисел.
        //Найдите раздницу между мах и мин элементом массива
        //[3,7,22,78] -> 76
        
        
        public static Random random = new Random();

        public static double[] RandomArrayGenerator()
        {
            double[] array = new double[random.Next(5, 11)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(9, 10) + random.NextDouble();
            }
            return array;
        }
        
        
        public static void DistributionNumber(double[] array)
        {
            double min = array.First();
            double max = array.First();
            Console.Write(" ");
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];

                if (max > array[i]) max = array[i];
                if (i != array.Length - 1) 
                {
                    Console.Write("{0}, ", Math.Round(array[i], 2));
                }
                else
                {
                     Console.Write("{0} -> {1}", Math.Round(array[i], 2), Math.Round(max - min));
                }
            }
        }
        static void Main(string[] asgs)
        {
           DistributionNumber(RandomArrayGenerator());
        }
    }
}