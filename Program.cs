using System;

namespace Encapsulamento_07
{
    class Program
    {
        static void Main(string[] args)
        {
           Cartao c1 = new Cartao();

           c1.AprovarCompra();

           Mastercard m1 = new Mastercard();

           m1.parcelas = 2;
           m1.DescontoMastercard (40);
        }
    }
}
