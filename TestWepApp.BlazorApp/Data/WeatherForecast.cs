namespace TestWepApp.BlazorApp.Data
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        //public int TemperatureF => TemperatureC > 0 ? 32 + (int)(TemperatureC / 0.5556)
        //                 : throw new DivideByZeroException();



        public string? Summary { get; set; }
    }
}