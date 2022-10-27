//Kelly Chen || kc4509@g.rit.edu

//I am currently fixing my removing() method because something funky is happening somewhere
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishroom
{
    //Worker class
    internal class Worker
    {
        //the ability of workers to extract items, the amount of time they might work before needing a break
        private double efficiency = 0;
        private int itemsRemoved = 0;
        private string name;
        int counter;
        
        //Create a Worker with generated efficiency and number of items they are removing
        public Worker()
        {
            this.efficiency = Numbers.genRandom(85, 101);
        }

        //sets worker's name
        public void setName(string name)
        {
            this.name = name;
        }

        //gets worker's name
        public string getName()
        {
            return name;
        }

        //returns the number of items that the worker can remove
        public int removing()
        {
            counter++;
            int items = 0;
            if (efficiency > 80 && efficiency < 101)
            {
                items = 6;
            }
            if (efficiency > 60 && efficiency < 80)
            {
                items = 5;
            }
            if (efficiency > 40 && efficiency < 60)
            {
                items = 4;
            }
            if (efficiency > 20 && efficiency < 40)
            {
                items = 3;
            }
            if (efficiency > 0 && efficiency < 20)
            {
                items = 2;
            }
            if (efficiency == 0)
            {
                items = 0;
            }

            if (counter % 2 == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (items >= Belt.getTrays()[i].getItems())
                    {
                        if (i == 0)
                        {
                            return Belt.getTrays()[i].getItems() - (Belt.getTrays()[i].getItems() / 2);
                        }
                        if (i == 1)
                        {
                            return Belt.getTrays()[i].getItems() - Belt.getTrays()[i].getItems() / 3;
                        }
                        if (i == 2)
                        {
                            return Belt.getTrays()[i].getItems() - Belt.getTrays()[i].getItems() / 4;
                        }
                        if (i == 3)
                        {
                            return Belt.getTrays()[i].getItems();
                        }
                    }
                    else
                    {
                        return items;
                    }
                }

            }
            else
            {
                for (int i = 0; i < 4; i++)
                 {
                    if (items >= Belt.getTrays()[i].getItems())
                    {
                        return Belt.getTrays()[i].getItems();
 
                    }
                    else
                    {
                        return items;
                    }
                }
            }
            return 0;
        }

        //returns the effiency of the worker
        public double getEffiency()
        {
            return efficiency;
        }

        //chagnes the effiency of the worker
        public void changeEff()
        {
            efficiency = efficiency * 0.95;
        }

        //sets the effiency of the worker
        public void setEffiency(double newEffiency)
        {
            this.efficiency = newEffiency;
        }

    }
}
