namespace Dunkar.Models
{
    public class PlayerStats
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        // Statistiques moyennes par match
        public double PointsParMatch { get; set; }
        public double RebondsParMatch { get; set; }
        public double PassesParMatch { get; set; }
        public double InterceptionsParMatch { get; set; }
        public double ContresParMatch { get; set; }
        public double FautesParMatch { get; set; }

        // Pourcentages de réussite
        public double PourcentageTirs { get; set; }
        public double PourcentageTroisPoints { get; set; }
        public double PourcentageLancersFrancs { get; set; }

        // Statistiques totales
        public int MatchsJoues { get; set; }
        public int MatchsCommences { get; set; }
        public int MinutesJouees { get; set; }

        public int Saison { get; set; }
    }
}
