using System;

namespace Lista21082017ex02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int totalEleitores, votosBrancos, votosNulos, votosValidos;
            decimal porcBrancos, porcNulos, porcValidos;
			Console.WriteLine("Digite a quantidade de eleitores: ");
            totalEleitores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos brancos: ");
            votosBrancos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos nulos: ");
            votosNulos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos válidos: ");
            votosValidos = Convert.ToInt32(Console.ReadLine());

            if ((votosBrancos + votosNulos + votosValidos) == totalEleitores)
            {
                porcBrancos = (votosBrancos * 100) / totalEleitores;
                porcNulos = (votosNulos * 100) / totalEleitores;
                porcValidos = (votosValidos * 100) / totalEleitores;
                Console.WriteLine("Porcentagem de votos brancos: {0}%", porcBrancos);
                Console.WriteLine("Porcentagem de votos nulos: {0}%", porcNulos);
                Console.WriteLine("Porcentagem de votos válidos: {0}%", porcValidos);
                Console.ReadLine();
            } else {
				Console.WriteLine("Quantidade de votos inválida.");
				Console.ReadLine();
            }

        }
    }
}
