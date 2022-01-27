using System;
using exemploPOO.Helper;
using exemploPOO.Interfaces;
using exemploPOO.Moldes;

namespace exemploPOO
{
    class Program
    {
        static void Main(String[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 2", "arquivo-teste-stream.txt");

            var ListaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var ListaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

            FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);
            // System.Console.WriteLine("Criando Diretorio: " + caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ApagarDiretorio(caminhoPathCombine, true);
            // helper.CriarArquivoTexto(caminhoArquivo, "Olá! teste de escrita de arquivo.");
            // helper.CriarArquivoTextoStream(caminhoArquivo, ListaString);
            // helper.AdicionarTextoStream(caminhoArquivo,ListaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);


            // iCalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));   
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10,10)); 

            //  Aluno p1 = new Aluno();
            //  p1.Nome = "Jennifer";
            //  p1.Idade = 28;
            //  p1.Documento = "1243093";
            //  p1.Nota = 10;
            //  p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Marina";
            // p2.Idade = 28;
            // p2.Documento = "1243093";
            // p2.Salario = 2000;
            // p2.Apresentar();


        //     //Valores validos
        //   retangulo r = new retangulo();
        //   r.DefinirMedidas(30, 30);
        //   System.Console.WriteLine($"Área: {r.ObterArea()}");
          
        //   //Valores invalidos
        //   retangulo r2 = new retangulo();
        //   r.DefinirMedidas(0, 0);
        //   System.Console.WriteLine($"Área: {r2.ObterArea()}");
          
          
           // Pessoa p1 = new Pessoa();

            // p1.Nome = "Jennifer";
            // p1.Idade = 28;

            // p1.Apresentar();
        }
    }
}