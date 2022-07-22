namespace HelloWorld
{
    class Program
    {
        //Задача 34. 
        //Задайте массив заполненный случайными положительными трехзначными
        //числами. Напишите программу которая покажет количество четных чисел в массиве.
        // [345, 897, 568,234]->2
        private static Random random = new Random();

        public static int[] RandomArrayGenerator()
        {
            int[] array = new int[random.Next(5, 11)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 1000);
            }
            return array;
        }
        
        
        public static void EvenNumber(int[] arrayR)
        {
            int count = 0;
            Console.Write(" ");
            for (int i = 0; i < arrayR.Length; i++)
            {
                if (arrayR[i] % 2 == 0) count++;
                if (i != arrayR.Length - 1)
                {
                    Console.Write("{0}, ", arrayR[i]);
                }
                else
                {
                     Console.Write("{0} -> {1}", arrayR[i], count);
                }
            }
        }
        static void Main(string[] asgs)
        {
            EvenNumber(RandomArrayGenerator());
        }
    }
}


