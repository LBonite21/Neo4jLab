using System;
using System.Collections.Generic;
using System.IO;

namespace Neo4jLab
{
    

    public class NeoCrud
    {
        private bool ChoiceSelected;
        CrudUI menu = new CrudUI();

        public NeoCrud()
        {
        }

        public void run()
        {
            ChoiceSelected = false;

            do
            {

                Selection(menu.MenuSelection());

            } while (ChoiceSelected);
        }

        public bool Selection(int UserSelction)
        {

            switch (UserSelction)
            {
                case 0:
                    System.Console.WriteLine("Closing . . . . . .");
                    ChoiceSelected = true;
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Creating...");

                    ChoiceSelected = true;
                    break;
                case 2:
                    Console.WriteLine("Reading...");

                    ChoiceSelected = true;
                    break;
                case 3:
                    Console.WriteLine("Updating...");

                    ChoiceSelected = true;
                    break;
                case 4:
                    Console.WriteLine("Deleting...");

                    ChoiceSelected = true;
                    break;
                default:
                    System.Console.WriteLine("Please enter the number options of 1 or 2");
                    break;
            }

            return ChoiceSelected;


        }

        public void CreateObject() 
        { 
        
        }

        public void ReadingObject()
        {

        }

        public void UpdatingObject()
        {

        }
        
        public void DeleteObject()
        {

        }
    }

}
