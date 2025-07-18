namespace Dunkar.Models
{
    // Modèle pour les saisons d'une équipe
    public class TeamSeason
    {
        public int Id { get; set; }

        public int EquipeId { get; set; }
        public virtual Team Equipe { get; set; }

        public int Saison { get; set; }

        public int Victoires { get; set; }
        public int Defaites { get; set; }

        public int PointsMarques { get; set; }
        public int PointsEncaisses { get; set; }

        public int? ClassementFinal { get; set; }

        public bool PlayoffsAtteints { get; set; }

        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
    }
}
