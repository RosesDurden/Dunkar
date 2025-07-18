namespace Dunkar.Models
{
    // Modèle pour un contrat
    public class Contract
    {
        public int Id { get; set; }

        public int? PlayerId { get; set; }
        public virtual Player? Player { get; set; }

        public int? CoachId { get; set; }
        public virtual Coach? Coach { get; set; }

        public int EquipeId { get; set; }
        public virtual Team Equipe { get; set; }

        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public decimal SalaireAnnuel { get; set; }

        public decimal? Prime { get; set; }

        public bool EstActif { get; set; }

        public DateTime DateSignature { get; set; }
    }
}
