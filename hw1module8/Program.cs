using System;


namespace hw2module8
{
    class SquareArray
    {
        private int[] array;

        public SquareArray(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value * value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SquareArray array = new SquareArray(5);

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Элемент по индексу {i}: {array[i]}");
            }
        }
    }
}
