using System;
using System.Collections.Generic;

namespace Games1
{

        class Animals
        {
            ConsoleColor Head = ConsoleColor.Green;
            public int Lenght { get; set; }
            public Turn Turner { get; set; }

           public Pixel First;
        public Apple apl { get; set; }



        public Animals(Pixel first, Turn turn = Turn.Right, int lenght = 3)
            {
                Turner = turn;
                Lenght = lenght;
                First = first;
                /* First.Drow();*/
                int i = lenght;

              
                        while (i > 0)
                        {
                            Pixel temp = new Pixel(First.X_poz - i, First.Y_poz);
                            i--;
                            /* temp.Drow();*/
                            qwe.Enqueue(temp);
                        }
                      
                

                
             /*   DrowAnimal();*/

            }

            public void DrowAnimal()
            {
               int x =Console.BufferWidth;
               int y =Console.BufferHeight;
                foreach (var item in qwe)
                {
                    item.Drow();
                }
                First.Drow();
            }

        public bool Move(ref Turn turn, ref int sleep) {
             




                
               Pixel temp = new Pixel(First);
                Pixel del = default; 
                switch (turn)
                {
                    case Turn.Down:
                        if (Turner == Turn.Up)
                    {
                        turn = Turn.Up;
                    return true; }
                    Turner = Turn.Down;
                        First = new Pixel(temp.X_poz , temp.Y_poz+1, Head);

                    if (!apl.Equals(temp))

                    {
                        del = qwe.Dequeue();
                     
                        
                    }
                    else {
                        sleep -= 5;
                        new Apple(this);
                    }
                    qwe.Enqueue(temp);
                    break;
                    case Turn.Left:
                        if (Turner == Turn.Right) {
                        turn = Turn.Right;
                        return true; }
                    Turner = Turn.Left;
                        First = new Pixel(temp.X_poz - 1, temp.Y_poz, Head);

                    if (!apl.Equals(temp))

                    {
                        del = qwe.Dequeue();
                        

                    }
                    else {
                        sleep -= 5;
                        new Apple(this);
                    }

                    qwe.Enqueue(temp);

                    break;
                    case Turn.Right:
                    if (Turner == Turn.Left) {
                        turn = Turn.Left;
                    return true; }
                    { Turner = Turn.Right; }
                        First = new Pixel(temp.X_poz + 1, temp.Y_poz, Head);

                    if (!apl.Equals(temp))

                    {
                        del = qwe.Dequeue();
                        

                    }
                    else {
                        sleep -= 5;
                        new Apple(this);
                    }
                    qwe.Enqueue(temp);
                    break;
                    case Turn.Up:
                        if (Turner == Turn.Down) { 
                        turn= Turn.Down;
                        return true; }
                    Turner = Turn.Up;
                        First = new Pixel(temp.X_poz , temp.Y_poz-1, Head);

                    if (!apl.Equals(temp))

                    {
                        del = qwe.Dequeue();
                        
                    }
                    else {
                        sleep -= 5;
                        new Apple(this);

                    }
                    qwe.Enqueue(temp);
                    break;
                    
                }
            /*del = qwe.Dequeue();
            qwe.Enqueue(temp);*/
            if (del!=default) del.Clear();


            if (qwe.Contains(First)) return false;
            if (First.X_poz < 1 || First.X_poz > Program._sizeW-2 
                || First.Y_poz<1||First.Y_poz>Program._sizeH-3
                ) return false;

/* if(!First.Equals(apl))
 { del = qwe.Dequeue();
     del.Clear();
                
 }
 else{ apl = new Apple(this);}*/

                
                return true;




            }


         

            public Animals():this(new Pixel(Program._sizeW / 2, Program._sizeH / 2, ConsoleColor.Blue))
            {
            }

            public Queue<Pixel> qwe { get; set; } = new Queue<Pixel>();



        }
    
}
