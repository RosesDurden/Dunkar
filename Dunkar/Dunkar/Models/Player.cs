using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Reflection;

namespace Dunkar.Models
{
    // Modèle pour un joueur de basket
    public class Player
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenom { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        [Range(16, 50)]
        public int Age { get; set; }

        [Range(150, 250)]
        public int Taille { get; set; } // en centimètres

        [Range(50, 200)]
        public int Poids { get; set; } // en kilogrammes

        public Position PostePrincipal { get; set; }

        public Position? PosteSecondaire { get; set; }

        [StringLength(3)]
        public string Nationalite { get; set; }

        public PlayerStatus Statut { get; set; }

        // Statistiques du joueur
        public PlayerStats Stats { get; set; }

        // Attributs/Compétences
        public PlayerAttributes Attributs { get; set; }

        // Contrat
        public Contract? ContratActuel { get; set; }

        // Équipe actuelle
        public int? EquipeId { get; set; }
        public virtual Team? Equipe { get; set; }

        // Historique des matchs
        public virtual ICollection<GamePlayerStats> HistoriqueMatchs { get; set; }

        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
    }
}
