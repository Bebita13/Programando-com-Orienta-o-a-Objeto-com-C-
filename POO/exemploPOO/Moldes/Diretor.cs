namespace exemploPOO.Moldes
{
    public class Diretor : Professor
    {
        public new double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }
    }
}