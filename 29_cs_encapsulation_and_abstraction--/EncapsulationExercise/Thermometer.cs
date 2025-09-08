using System;

namespace EncapsulationExercise
{
  // Class – Thermometer
  public class Termometer
  {
    // Field – Temperature in Celsius
    private double _temeratureCelsius;

    // Property – Gets temperature
    public double TemperatureCelsius
    {
      get { return _temeratureCelsius; }
      private set { _temeratureCelsius = value; }
    }

    // Method – Sets temperature
    public void SetTemperature(double value)
    {
      if (value >= -50 && value <= 100)
      {
        _temeratureCelsius = value;
      }
      else
      {
        Console.WriteLine("Temperature must be between -50 and 100");
      }
    }
  };

  // Extension method – Converts Celsius to Fahrenheit
  public double GetFahrenheit()
  {
    return (_temeratureCelsius * 9.0 / 5.0) + 32;
  }

}
