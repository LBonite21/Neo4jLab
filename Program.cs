using Neo4jClient;
using System;

namespace Neo4jLab
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var client = new GraphClient(new Uri("http://localhost:7474/db/products"), "neo4j", "Neo");
            NeoCrud bleh = new NeoCrud();
            bleh.run();
        }
    }
}
