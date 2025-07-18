using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Dunkar.Models
{
    // Modèle pour un entraîneur
    public class Coach
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenom { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        public int Age { get; set; }

        [StringLength(3)]
        public string Nationalite { get; set; }

        public int Experience { get; set; } // en années

        // Compétences d'entraîneur (0-100)
        [Range(0, 100)]
        public int CompetenceOffensive { get; set; }

        [Range(0, 100)]
        public int CompetenceDefensive { get; set; }

        [Range(0, 100)]
        public int Motivation { get; set; }

        [Range(0, 100)]
        public int GestionJoueurs { get; set; }

        [Range(0, 100)]
        public int TactiqueSituations { get; set; }

        // Équipe actuelle
        public int? EquipeId { get; set; }
        public virtual Team? Equipe { get; set; }

        // Contrat
        public virtual Contract? ContratActuel { get; set; }

        public DateTime DateCreation { get; set; }
    }
}
