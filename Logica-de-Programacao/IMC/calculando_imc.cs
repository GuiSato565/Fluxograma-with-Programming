using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double peso, altura, imc;
        
        peso = readValue();
        altura = readValue();
        imc = peso / (altura * altura);
        if (imc <= 18.5)
        {
            Console.WriteLine("Seu IMC é " + toFixed(imc, 2) + ". Status: Magreza");
        }
        else
        {
            if (imc >= 18.8 && imc <= 24.9)
            {
                Console.WriteLine("Seu imc é " + toFixed(imc, 2) + ". Status: Normal");
            }
            else
            {
                if (imc >= 25 && imc <= 29.9)
                {
                    Console.WriteLine("Seu imc é " + toFixed(imc, 2) + ". Status: Sobrepeso");
                }
                else
                {
                    if (imc >= 30 && imc <= 39.9)
                    {
                        Console.WriteLine("Seu IMC é " + toFixed(imc, 2) + ". Status: Obesidade");
                    }
                    else
                    {
                        if (imc >= 40)
                        {
                            Console.WriteLine("Seu IMC é " + toFixed(imc, 2) + ". Status: Obesidade Grave");
                        }
                    }
                }
            }
        }
    }
    
    private static String toFixed(double value, int digits)
    {
        return String.format("%." + digits + "f", value);
    }
    
    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
