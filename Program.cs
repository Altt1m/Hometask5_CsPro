using Hometask5.Enums;

namespace Hometask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Piece destructor
            //Test1();
            //GC.Collect();

            //// Store Dispose()
            //Test2();

            //// Piece Dispose()
            //Test3();

            //// Store destructor
            //Test4();
            //GC.Collect();

        }

        public static void Test1() // Piece destructor
        {
            Piece myPiece = new Piece("Moonlight Sonata", "Ludwig van Beethoven", "Classical", 1801);
            myPiece.Show();
        }

        public static void Test2() // Store Dispose()
        {
            using (Store groceryStore = new Store("SuperStore", "123 Example St", StoreTypes.Footwear))
            {
                groceryStore.Show();
            } // Dispose() will be automatically called after leaving the "using" block
        }

        public static void Test3() // Piece Dispose()
        {
            using (Piece myPiece = new Piece("Moonlight Sonata", "Ludwig van Beethoven", "Classical", 1801))
            {
                myPiece.Show();
            }
        }

        public static void Test4() // Store destructor
        {
            Store groceryStore = new Store("SuperStore", "123 Example St", StoreTypes.Footwear);
            groceryStore.Show();
        }
    }
}