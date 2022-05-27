static double CelciusAFahren (double TemperaCelc) // convert celcius to Fahrenheit
{
    double TemperaFah = 0;
    TemperaFah = (TemperaCelc * 9) / 5 + 32; // convert formula
    return TemperaFah;
}

static double FahrenACelcius (double Fahrenheit) // Fahrenheit to Celcius
{
    return (Fahrenheit - 32) * 5 / 9; //Formula
}

static double CelciusAKelvin (double celcius) // Celcius to Kelvin
{
    return (celcius + 273.15); // formula
}

Console.Write("Introducir el valor de la temperatura en Celcius(C) para Fahrenheit: "); //ask
double celtemp = Convert.ToDouble(Console.ReadLine());// capture the values from the console Celcius


Console.Write("Introducir el valor de la temperatura en Fahrenheit(F) para Celcius: "); //ask
double Fahrenheit = Convert.ToDouble(Console.ReadLine()); //capture values from fahrenheit

Console.Write("Introducir el valor de la temperatura en Celcius(C) para Kelvin: "); //ask
double Kelvin = Convert.ToDouble(Console.ReadLine()); //capture values Celcius to Kelvin


double ferTemp = CelciusAFahren(celtemp);
Console.WriteLine("La conversion de Celcius A Fahrenheit es : " + ferTemp);


                                                      



