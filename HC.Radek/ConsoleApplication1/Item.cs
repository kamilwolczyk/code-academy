using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Item
    {
        private int prize;
        private int value;

        public Item(int _prize, int _value)
        {
            prize = _prize;
            value = _value;
        }

        public int GetPrize()
        {
            return prize;
        }

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int _value)
        {
            value = _value;
        }

        public void SetPrize(int _prize)
        {
            prize = _prize;
        }


    }
}
