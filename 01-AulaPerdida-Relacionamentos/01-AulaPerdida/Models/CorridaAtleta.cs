namespace _01_AulaPerdida.Models
{
    public class CorridaAtleta
    {
        public int CorridaId { get; set; }
        public Corrida Corrida { get; set; }

        public int AtletaId { get; set; }
        public Atleta Atleta { get; set; }

    }
}