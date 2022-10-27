//Kelly Chen || kc4509@g.rit.edu
using System;

namespace Dishroom
{
    //Belt class
    internal class Belt
    {
        //array of trays
        protected static Tray[] trays = new Tray[4];

        //array of workers
        protected static Worker[] workers = new Worker[4];

        //counts items that don't get removed
        protected static int itemsLeft;

        //Creates a new tray
        public static void generateTrays()
        {
            trays = new Tray[4];
            for (int i = 0; i < trays.Length; i++)
            {
                trays[i] = new Tray();
                trays[i].setItems(0);
            }
        }

        //moves tray down the line
        public static void addTray()
        {
            //Console.WriteLine(trays[3].getItems());
            if (trays[3].getItems() > 0)
            {
                itemsLeft = itemsLeft + trays[3].getItems();
            }
            trays[3].setItems(trays[2].getItems());
            trays[2].setItems(trays[1].getItems());
            trays[1].setItems(trays[0].getItems());
            trays[0].setItems(Numbers.genRandom(0, 6));
        }

        //Creates the 4 Workers with different efficiency
        public static void generateWorkers()
        {
            for (int i = 0; i < 4; i++)
            {
                int currentNum = i + 1;
                Console.WriteLine("Enter worker " + currentNum + " name: ");
                string name = Console.ReadLine();
                workers[i] = new Worker();
                workers[i].setName(name);
                workers[i].setEffiency(Numbers.genRandom(85, 101));
            }
        }

        //returns the array of workers
        public static Worker[] getWorkers()
        {
            return workers;
        } 

        //returns the array of trays
        public static Tray[] getTrays()
        {
            return trays;
        }

        //returns the number of items left
        public static int getItemsLeft()
        {
            return itemsLeft;
        }

        //prints the result of the number of items in tray per run
        public static void printTray()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Items in " + i + " tray: " + trays[i].getItems());
            }

        }

        //print the effiency of the workers per run
        public static void printWorker()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Worker " + workers[i].getName() + " current efficiency level: " + workers[i].getEffiency());
            }
        }
    }
}
