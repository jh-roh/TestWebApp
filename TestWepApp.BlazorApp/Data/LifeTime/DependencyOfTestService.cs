using DevExpress.Xpo;
using System;

namespace TestWepApp.BlazorApp.Data.LifeTime
{
    public class SingletonService : IDisposable
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public void Dispose()
        {
            Console.WriteLine("SingletonService disposed");
        }
    }

    public class TransientService : IDisposable
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public void Dispose()
        {
            Console.WriteLine("TransientService disposed");
        }
    }

    public class ScopedService : IDisposable
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public void Dispose()
        {
            Console.WriteLine("ScopedService disposed");
        }
    }

}