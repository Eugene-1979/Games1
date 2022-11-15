using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games1
{
    internal class Apple
    {
        public Pixel Appl{ get; set; }

        public override bool Equals(object obj)
        {
           return Appl.Equals((Pixel)obj);

        }

        public Apple(Animals an)
        {
       
            Random random = new Random();
            Pixel temp;
            /* проверяем ,чтобы яблоко не попало на змею при создании*/
            do
            {

                temp = new Pixel(random.Next(1,Program._sizeW-2), random.Next(1,Program._sizeH-2), ConsoleColor.Red);
                /* temp = new Pixel(51, 25, ConsoleColor.Red);*/

            } while (an.qwe.Contains(temp) || an.First.Equals(temp));
            Appl = temp;
            an.apl = this;
            temp.Drow();


        }
    }
}
