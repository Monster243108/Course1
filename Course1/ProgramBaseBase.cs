using System;
using System.Globalization;

 namespace Course1{
    internal class ProgramBaseBase {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo o preço é {1:F3} reais!" , produto1, preco1);
            Console.WriteLine("{0}, cujo o preço é {1:F3} reais!" , produto2, preco2);
            
            Console.WriteLine("Medida! " + medida.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Registro: {0} anos de idade, codigo {1} e genero: {2}", idade, codigo, genero);



        }  
}
}
