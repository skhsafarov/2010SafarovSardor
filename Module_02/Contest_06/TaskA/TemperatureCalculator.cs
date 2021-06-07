using System;

public static class TemperatureCalculator
{
    public static double FromCelsiusToFahrenheit(double celsiusTemperature)
    {
        double res = (celsiusTemperature * 9 / 5) + 32;
        if (FromFahrenheitToKelvin(res) < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        else
        {
            return res;
        }
    }

    public static double FromCelsiusToKelvin(double celsiusTemperature)
    {
        double res = celsiusTemperature + 273.15;
        if (res < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        else
        {
            return res;
        }
    }

    public static double FromFahrenheitToCelsius(double fahrenheitTemperature)
    {
        double res = (fahrenheitTemperature - 32) * 5 / 9;
        if (FromFahrenheitToKelvin(fahrenheitTemperature) < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        else
        {
            return res;
        }
    }

    public static double FromFahrenheitToKelvin(double fahrenheitTemperature)
    {
        double res = ((fahrenheitTemperature - 32) * 5 / 9 + 273.15);
        if (res < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        else
        {
            return res;
        }
    }

    public static double FromKelvinToCelsius(double kelvinTemperature)
    {
        double res = kelvinTemperature - 273.15;
        if (kelvinTemperature < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        else
        {
            return res;
        }
    }

    public static double FromKelvinToFahrenheit(double kelvinTemperature)
    {
        double res = ((kelvinTemperature - 273.15) * 9 / 5 + 32);
        if (kelvinTemperature < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        else
        {
            return res;
        }
    }
}