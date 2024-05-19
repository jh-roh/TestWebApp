using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWepApp.Components.Library.Data
{
    public class Measurement
    {
        public Guid Guid { get; set; }
        public double Min { get; set; }
        public double Avg { get; set; }
        public double Max { get; set; }

    }

    public class MeasurementsService
    {
        public ValueTask<List<Measurement>> GetMeasurements()
        {
            const int nrOfRows = 5000;

            var result = new List<Measurement>();
            var rnd = new Random();

            for(int i = 0; i < nrOfRows; i++) 
            {
                result.Add(new Measurement()
                {
                    Guid = Guid.NewGuid(),
                    Min = rnd.Next(0,100),
                    Avg = rnd.Next(100,300),
                    Max = rnd.Next(300,400)
                });
            }

            return new ValueTask<List<Measurement>>(result);
        }


    }
}
