namespace _01_AulaPerdida.Models
{
    public class CorridaAtleta
    {
        public Corrida Corrida { get; set; }

        public int CorridaId { get; set; }

        public Atleta Atleta { get; set; }

        public int AtletaId { get; set; }
    }
}