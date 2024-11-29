using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());
        double L = double.Parse(Console.ReadLine());

        double kilogramm = 0;
        bool isValid = true;

        switch (N)
        {
            case 1: 
                kilogramm = L * 0.1;
                break;
            case 2: // miligramm
                kilogramm = L * 0.001;
                break;
            case 3: // gramm
                kilogramm = L * 0.001;
                break;
            case 4: // tonn
                kilogramm = L * 1000;
                break;
            case 5: // sentner
                kilogramm = L * 100;
                break;
            default: 
                isValid = false;
                Console.WriteLine("Ошибка: номер единицы длины должен быть в диапазоне 1-5.");
                break;
        }

        
        if (isValid)
        {
            Console.WriteLine($"Vazn  bo kilogram : {kilogramm}");
        }
    }
}