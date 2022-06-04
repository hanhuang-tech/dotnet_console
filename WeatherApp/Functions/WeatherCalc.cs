using System.Collections.Generic;
using System.Linq;


namespace WeatherApp.Functions
{
    internal class WeatherCalc
    {
        public static (WeatherByDay max, WeatherByDay min) MinMaxTemp(IEnumerable<WeatherByDay> weatherByDays)
        {
            var max = weatherByDays.MaxBy(d => d.DiffT);
            var min = weatherByDays.MinBy(d => d.DiffT);
            return (max, min);
        }
    }
}