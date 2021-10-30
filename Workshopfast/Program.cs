using System;

namespace Workshopfast
{
    class Program 
    {
        static void Main(string[] args)
        {
            int workshop;
            Console.WriteLine("Quantos workshop quer verificar ?");
            workshop = int.Parse(Console.ReadLine());

            string[] atas = new string [workshop];
            for (int i = 0; i < atas.Length; i++)
            {
                Console.WriteLine($"Digite os identificadores das pessoas que participaram do {i+1} WorkShop");
                atas[i] = Console.ReadLine();
            }
            AnalisadorDePresenca analisador = new AnalisadorDePresenca(atas);
            var listaFinal = analisador.ColaboradoresQueViram2WorkshopsSeguidos(); 
            foreach(var a in listaFinal)
            {
                Console.WriteLine(a);
            }
        }
    }
}
