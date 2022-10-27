//Kelly Chen || kc4509@g.rit.edu
//IGME 206 (E8 Dishroom)

//Generates a model of a dishroom where leftover trays and utensils get placed to be removed and washed by 4 workers. 
using System;

namespace Dishroom
{
    class Program
    {

        static void Main(string[] args)
        {
            model();
        }

        //Model of the dishroom
        static void model()
        {
            Belt.generateTrays();
            Belt.generateWorkers();
            while (Belt.getItemsLeft() < 10)
            {
                run();
                results();
            }
            stop();
        }

        //one run of the process
        static void run()
        {
            for (int i = 0; i < Belt.getTrays().Length; i++)
            {
                Belt.getWorkers()[i].changeEff();
                Console.WriteLine(Belt.getWorkers()[i].removing());
                if (Belt.getTrays()[i].getItems() - Belt.getWorkers()[i].removing() > 0)
                {
                    Belt.getTrays()[i].setItems(Belt.getTrays()[i].getItems() - Belt.getWorkers()[i].removing());
                }
            }
            Belt.addTray();
        }

        //prints the results
        static void results()
        {
            Belt.printTray();
            Belt.printWorker();
        }

        //stops the model
        static void stop()
        {
            Console.WriteLine("Too many utensils losted :(");
            return;
        }
    }
    
}