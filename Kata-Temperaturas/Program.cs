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

