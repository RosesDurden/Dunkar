using System.ComponentModel.DataAnnotations;

namespace Dunkar.Models
{
    // Modèle pour une équipe
    public class Team
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nom { get; set; }

        [StringLength(50)]
        public string Ville { get; set; }

        [StringLength(10)]
        public string Abreviation { get; set; }

        [StringLength(7)]
        public string CouleurPrincipale { get; set; }

        [StringLength(7)]
        public string CouleurSecondaire { get; set; }

        public TeamStatus Statut { get; set; }

        public int Budget { get; set; }

        public int PlafondSalarial { get; set; }

        // Relations
        public virtual ICollection<Player> Joueurs { get; set; }
        public virtual ICollection<Game> MatchsDomicile { get; set; }
        public virtual ICollection<Game> MatchsExterieur { get; set; }
        public virtual Coach? EntraineurPrincipal { get; set; }
        public virtual ICollection<TeamSeason> SaisonsEquipe { get; set; }

        public DateTime DateCreation { get; set; }
    }
}
