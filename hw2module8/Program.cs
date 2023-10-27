using System;



namespace hw2module8
{
    class Program
    {
        static void Main(string[] args)
        {
            double heatingRate = 2500; //тариф на отопление на 1/м2 площади
            double waterRate = 1200; //тариф на воду на 1 чел
            double gasRate = 1800; //тариф на газ на 1 чел
            double repairRate = 3000; //  тариф на ремонт на 1/м2 площади

            int area = 100; // площадь помещения в квадратных метрах
            int numberOfResidents = 4; // количество человек
            bool hasVeteranDiscount = true; // ветеран труда

            //оплата для каждого вида платежа
            double totalHeating = area * heatingRate;
            double totalWater = numberOfResidents * waterRate;
            double totalGas = numberOfResidents * gasRate;
            double totalRepair = area * repairRate;

            double totalCost = totalHeating + totalWater + totalGas + totalRepair;
            
            //сумма к оплате
            double discount = 0;
            if (hasVeteranDiscount)
            {
                discount = totalCost * 0.3; // скидка 30% 
            }

            double finalCost = totalCost - discount;

            //вывод таблицы
            Console.WriteLine("Вид платежа\tНачис.\tCкидка\tИтого");
            Console.WriteLine($"Отопление\t{totalHeating}\t{(hasVeteranDiscount ? (totalHeating * 0.3).ToString() : "0")}\t{totalHeating - (hasVeteranDiscount ? (totalHeating * 0.3) : 0)}");
            Console.WriteLine($"Вода\t\t{totalWater}\t{(hasVeteranDiscount ? (totalWater * 0.3).ToString() : "0")}\t{totalWater - (hasVeteranDiscount ? (totalWater * 0.3) : 0)}");
            Console.WriteLine($"Газ\t\t{totalGas}\t{(hasVeteranDiscount ? (totalGas * 0.3).ToString() : "0")}\t{totalGas - (hasVeteranDiscount ? (totalGas * 0.3) : 0)}");
            Console.WriteLine($"Ремонт\t\t{totalRepair}\t{(hasVeteranDiscount ? (totalRepair * 0.3).ToString() : "0")}\t{totalRepair - (hasVeteranDiscount ? (totalRepair * 0.3) : 0)}");
            Console.WriteLine($"\t\t{totalCost}\t{discount}\t{finalCost}");

        }
    }
}
