namespace workWithColums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //генерируется прямоугольный массив (количество строк не равно столбцам)
            //найти наибольший элемент  в каждом столбце!!
            //и записать его в вектор максимальных элементов

            Console.WriteLine("введите количество строк в массиве");
            int row = Int32.Parse(Console.ReadLine()); //количество строк
            Console.WriteLine("введите количество столбцов в массиве");
            int column = Int32.Parse(Console.ReadLine()); // количество столбцов

            int[,] array = new int[row, column]; //создание и инициализация двумерного массива

            Random random = new Random();

            //заполнение и вывод массива
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 100);

                        Console.Write(array[i, j]+" ");
                   
                }
                Console.WriteLine();
            }

            int[] maximumOfColumns = new int[column]; // создание вектора максимальных значений по столбцам
           
            //поиск максимальных значений
            //внешний цикл перебирает столбцы
            //внутренний элементы в каждом столбце
            for (int j = 0; j< array.GetLength(1); j++)
            {
                int max = Int32.MinValue; //эталон для сравнения
                for (int i = 0; i< array.GetLength(0); i++)
                {
                    //получение максимального значения и завпись во временную
                    //переменную max для дальнейшего сравнения
                    if (array[i,j] > max)
                    {
                        max = array[i,j];
                    }
                }
                maximumOfColumns[j] = max;
            }

            Console.WriteLine("максимальные значения в каждом столбце:");

            foreach(int item in maximumOfColumns)
                Console.Write(item+" ");
        }
    }
}