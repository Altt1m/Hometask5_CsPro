using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask5
{
    internal class Piece : IDisposable
    {
        private string Name { get; set; }
        private string Author { get; set; }
        private string Genre { get; set; }
        private int Year { get; set; }

        public Piece(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
            Console.WriteLine($"Piece \"{Name}\" has been created.\n");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Author: {Author}\n" +
                $"Genre: {Genre}\n" +
                $"Year: {Year}\n");
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

        ~Piece()
        {
            Dispose(false);
            Console.WriteLine($"Destructor has been called for \"{Name}\".\n");
        }
    }
}
