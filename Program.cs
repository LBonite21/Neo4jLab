using Neo4jClient;
using System;

namespace Neo4jLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new GraphClient(new Uri("http://localhost:7474/db/products", "neo4j", "Neo"));
        }

        public static int RequestInt(string message)
        {
            System.Console.Write(message);
            int input = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();
            return input;
        }

        public static string RequestString(string message)
        {
            System.Console.Write(message);
            string input = System.Console.ReadLine();
            System.Console.WriteLine();

            return input;
        }
    }
}
