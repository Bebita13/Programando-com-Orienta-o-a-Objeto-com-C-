namespace exemploPOO.Moldes
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou uma aluna nota {Nota}.");
        }
    }
}