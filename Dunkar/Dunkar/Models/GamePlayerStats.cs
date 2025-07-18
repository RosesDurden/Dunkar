namespace Dunkar.Models
{
    // Modèle pour les statistiques d'un joueur lors d'un match
    public class GamePlayerStats
    {
        public int Id { get; set; }

        public int GameId { get; set; }
        public virtual Game Game { get; set; }

        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public int MinutesJouees { get; set; }

        public int Points { get; set; }
        public int Rebonds { get; set; }
        public int Passes { get; set; }
        public int Interceptions { get; set; }
        public int Contres { get; set; }
        public int Fautes { get; set; }

        public int TirsReussis { get; set; }
        public int TirsTentes { get; set; }
        public int TroisPointsReussis { get; set; }
        public int TroisPointsTentes { get; set; }
        public int LancersFrancsReussis { get; set; }
        public int LancersFrancsTentes { get; set; }

        public bool EstTitulaire { get; set; }
    }

}
