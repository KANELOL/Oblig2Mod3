using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SimpleChess
{
    class Rook: Piece
    {
        //public Rook(string symbol) : base(symbol) => Symbol = "TRN";
        public Rook() : base("TRN")
        {
        }
        public override bool Move(string fromPosition, string toPosition)
        {
            Console.WriteLine("Rook Move");
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }

       
    }
}
