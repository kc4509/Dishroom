//Kelly Chen || kc4509@g.rit.edu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishroom
{
    //Tray class
    internal class Tray
    {
        //number of items in the tray
        private int items;

        //Constructer 
        public Tray()
        {
            this.items = 0; 
        }

        //gets number of item in tray 
        public int getItems()
        {
            return items;
        }

        //sets the numebr of items 
        public void setItems(int newItem)
        {
            this.items = newItem;
        }

        ////the number of items removed
        //public int removedItems(int r)
        //{
        //    if (r > items)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return r;
        //    }
        //}

        public bool isEmpty()
        {
            if (items > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
