using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games1
{
    internal struct Pixel : IEquatable<Pixel>
    {

        const char ch = (char)219;
       public int X_poz, Y_poz;
        ConsoleColor color;


        public Pixel(int X_poz, int Y_poz, ConsoleColor color=ConsoleColor.Yellow)
        {
            this.X_poz = X_poz;
            this.Y_poz = Y_poz;
            this.color = color;
        }
        public Pixel(Pixel px) {
            X_poz = px.X_poz;
            Y_poz = px.Y_poz;
            color = ConsoleColor.Yellow;
        
        }
       public void Drow()
        {
            Console.SetCursorPosition(X_poz, Y_poz);
            Console.BackgroundColor=color;
            Console.Write(ch);

        }

        public void Clear() {
            Console.SetCursorPosition(X_poz, Y_poz);
        Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(' ');
            
        
        }

        public override bool Equals(object obj)
        {
            return obj is Pixel pixel && Equals(pixel);
        }

        public bool Equals(Pixel other)
        {
            return X_poz == other.X_poz &&
                   Y_poz == other.Y_poz;
        }

        public override int GetHashCode()
        {
            int hashCode = 1882343103;
            hashCode = hashCode * -1521134295 + X_poz.GetHashCode();
            hashCode = hashCode * -1521134295 + Y_poz.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Pixel left, Pixel right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Pixel left, Pixel right)
        {
            return !(left == right);
        }
    }
}
