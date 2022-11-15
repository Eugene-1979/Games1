using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using static System.Console;

namespace Games1
{




    internal partial class Program
    {
       public const int _sizeH = 50;
    public const int _sizeW= 100;
       static ConsoleColor color = ConsoleColor.Yellow;

      
        static void Main()

        {

        Animals animals = new Animals();
            
            ConsoleKeyInfo consoleKeyInfo=default;
            Turn tt = Turn.Right;
            
            GameConsole();


Apple apple = new Apple(animals);
 Task <ConsoleKeyInfo> task = new Task<ConsoleKeyInfo>(()=> {
             
                return Console.ReadKey(true); });
            task.Start();
            int sleep = 100;

            while (true)
            {

                

                Thread.Sleep(sleep);


               /* сделал асинхронность через Task*/
                if (task.IsCompleted) {
                    consoleKeyInfo = task.Result;
tt = (Turn)(int)consoleKeyInfo.Key;
                task = new Task<ConsoleKeyInfo>(() => { return Console.ReadKey(true); });
                    task.Start();
                }

                /*Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;*/

                animals.DrowAnimal();
               

             /*   ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);*/

                if (consoleKeyInfo.Key == ConsoleKey.Escape) break;
                  

 if (!animals.Move(ref tt,ref sleep)) break;



                
               /* animals.Move(Turn.Up);*/
                /*new Animals(new Pixel(10, 10), (Turn)(int)consoleKeyInfo.Key, 5);*/
               



            }



        }



      



       



        static void GameConsole() {
            SetWindowSize(1, 1);
            SetBufferSize(_sizeW, _sizeH);
            SetWindowSize(_sizeW, _sizeH);
            CursorVisible = false;
            for (int i = 0; i < _sizeW; i++)
            {
                Pixel px = new Pixel(i, 1, color);
                px.Drow();
                Pixel px1 = new Pixel(i, _sizeH-1, color);
                px1.Drow();

            }
            for (int i = 0; i <_sizeH-1; i++)
            {
                new Pixel(0,i,color).Drow();
                new Pixel(_sizeW-1,i,color).Drow();


            }
               
        }

       
         
        static void DrowAnimal(Animals n,Turn turn) {

            Pixel px = n.qwe.Peek();



       
        
        }
    }
}
