namespace ArraysDemension2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер квадратного массива");
            int n = Int32.Parse(Console.ReadLine());

            int[,] array = new int[n,n]; //создание и инициализация двумерного массива

            Random random = new Random();
            
            //заполнение и вывод массива с одновременным выделением цветом
            //элементов на главной и побочной диагонали
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 100);

                    if(i==j) //если элемент лежит на главное диагонали
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(array[i, j]+" ");
                        Console.BackgroundColor = ConsoleColor.Black;//обязательно вернуть цвет в изначальный
                    }
                    else if (i==array.GetLength(1)-j-1) //если на побочной диагонали
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Write(array[i, j]+" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.Write(array[i, j]+" ");
                    }
                }
                Console.WriteLine();
            }

            //цикл для смены места элементов главной и побочной диагонали
            for (int i = 0; i < array.GetLength(0); i++)
            {
                //проход по каждой строке с обращением к определенным элементам главной и побочной диагонали
                int temp = array[i, i]; //во временную переменную кладется значение элемента главной диаогнали
                array[i, i] = array[i, n-i-1]; //на место главной диагонали записывается значение элемента побочной диагонали
                array[i, n-i-1] = temp; //на мето элемента побочной диагонали возвращается значение из временной переменной
            }


            Console.WriteLine("смена элементов главной и побочной диагонали");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i==j) //если элемент лежит на главное диагонали
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(array[i, j]+" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (i==array.GetLength(1)-j-1) //если на побочной диагонали
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Write(array[i, j]+" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.Write(array[i, j]+" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}