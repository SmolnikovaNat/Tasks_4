namespace HelloWorld
{
    class Program
    {
        //Задача 36. Задайте одномерный массив, заполненный случайными числами.
        //Найдите сумму элементов стоящих на нечетных позициях.
        //[3,7,23,12] -> 9
        //[-4,-6,89,6]-> 0
        
        private static Random random = new Random();

        public static int[] RandomArrayGenerator()
        {
            int[] array = new int[random.Next(5, 11)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            return array;
        }
        
        
        public static void EvenNumber(int[] arrayR)
        {
            int sumCount = 0;
            Console.Write(" ");
            for (int i = 0; i < arrayR.Length; i++)
            {
                if (i % 2 != 0) sumCount += arrayR[i];

                if (i != arrayR.Length - 1)
                {
                    Console.Write("{0}, ", arrayR[i]);
                }
                else
                {
                     Console.Write("{0} -> {1}", arrayR[i], sumCount);
                }
            }
        }
        static void Main(string[] asgs)
        {
            EvenNumber(RandomArrayGenerator());
        }
    }
}