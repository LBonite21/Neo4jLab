namespace Neo4jLab
{
    using System;

    internal class CrudUI
    {
        public CrudUI()
        {

        }
        public int MenuSelection()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("\n - Employee Info Stuff -\n " +
                "\n  1: Create Product " +
                "\n  2: Retrive Product " +
                "\n  3: Update Product " +
                "\n  4: Delete Product " +
                "\n  0: Exit");
            System.Console.Write("\n  Enter Choice: ");
            int input = int.Parse(System.Console.ReadLine());
            return input;
        }

        public int RequestInt(string message)
        {
            System.Console.Write(message);
            int input = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();
            return input;
        }

        public string RequestString(string message)
        {
            System.Console.Write(message);
            string input = System.Console.ReadLine();
            System.Console.WriteLine();

            return input;
        }
    }

}
