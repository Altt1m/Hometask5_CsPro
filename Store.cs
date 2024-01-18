using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask5.Enums;

namespace Hometask5
{
    internal class Store : IDisposable
    {
        private string Name { get; set; }
        private string Address { get; set; }
        private StoreTypes StoreType { get; set; }

        public Store(string name, string address, StoreTypes storeType)
        {
            Name = name;
            Address = address;
            StoreType = storeType;
            Console.WriteLine($"Store \"{Name}\" has been created.\n");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Address: {Address}\n" +
                $"Type: {StoreType}\n");
        }


        // IDisposable implementation
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                // Disposing managed resources
                Console.WriteLine($"Disposing managed resources for \"{Name}\".");
            }
            // Disposing unmanaged resources
            Console.WriteLine($"Disposing unmanaged resources for \"{Name}\".");
            disposing = true;
        }

        public void Dispose() 
        {
            // Freeing unmanaged resources
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Destructor (finalizer)
        ~Store()
        {
            Dispose(false);
            Console.WriteLine($"Desctructor (finalizer) called for {Name}");
        }

    }
}
