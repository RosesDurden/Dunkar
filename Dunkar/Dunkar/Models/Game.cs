namespace Dunkar.Models
{
    // Modèle pour un match
    public class Game
    {
        public int Id { get; set; }

        public int EquipeDomicileId { get; set; }
        public virtual Team EquipeDomicile { get; set; }

        public int EquipeExterieurId { get; set; }
        public virtual Team EquipeExterieur { get; set; }

        public DateTime DateMatch { get; set; }

        public int? ScoreDomicile { get; set; }
        public int? ScoreExterieur { get; set; }

        public bool EstTermine { get; set; }

        public ChampionshipType TypeChampionnat { get; set; }

        public int Saison { get; set; }
        public int? Journee { get; set; }

        // Statistiques des joueurs pour ce match
        public virtual ICollection<GamePlayerStats> StatistiquesJoueurs { get; set; }

        public DateTime DateCreation { get; set; }
    }
}
