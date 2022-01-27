namespace exemploPOO.Moldes
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou uma professora e ganho {Salario}.");
        }
    }
}