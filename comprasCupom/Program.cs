using System;

namespace comprasCupom
{
    class Program
    {
        static void Main(string[] args)
        {
            double vCompra, tCompra;
            string cupom;

            Console.WriteLine("Digite o valor da compra");
            vCompra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o cupom");
            cupom = Console.ReadLine().ToUpper();

            if(vCompra > 1000 || cupom == "DESCONTO20")
            {
                tCompra = vCompra - (vCompra * 0.20);
            }
            else
            {
                tCompra = vCompra;
            }
            Console.WriteLine("O Total da compra é de R$ {0}", tCompra.ToString("0.00"));
        }
    }
}
