using System.ComponentModel.DataAnnotations;

namespace Dunkar.Models
{
    // Modèle pour les attributs/compétences d'un joueur
    public class PlayerAttributes
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        // Attributs physiques (0-100)
        [Range(0, 100)]
        public int Vitesse { get; set; }

        [Range(0, 100)]
        public int Force { get; set; }

        [Range(0, 100)]
        public int Endurance { get; set; }

        [Range(0, 100)]
        public int Agilite { get; set; }

        [Range(0, 100)]
        public int Detente { get; set; }

        // Attributs techniques (0-100)
        [Range(0, 100)]
        public int TirPres { get; set; }

        [Range(0, 100)]
        public int TirMiDistance { get; set; }

        [Range(0, 100)]
        public int TirTroisPoints { get; set; }

        [Range(0, 100)]
        public int LancersFrancs { get; set; }

        [Range(0, 100)]
        public int Dribble { get; set; }

        [Range(0, 100)]
        public int Passe { get; set; }

        [Range(0, 100)]
        public int RebondOffensif { get; set; }

        [Range(0, 100)]
        public int RebondDefensif { get; set; }

        [Range(0, 100)]
        public int DefenseInterieure { get; set; }

        [Range(0, 100)]
        public int DefenseExterieure { get; set; }

        [Range(0, 100)]
        public int Contre { get; set; }

        [Range(0, 100)]
        public int Interception { get; set; }

        // Attributs mentaux (0-100)
        [Range(0, 100)]
        public int VisionDeJeu { get; set; }

        [Range(0, 100)]
        public int Leadership { get; set; }

        [Range(0, 100)]
        public int Concentration { get; set; }

        [Range(0, 100)]
        public int GestionPression { get; set; }

        // Note globale calculée
        public int NoteGlobale { get; set; }
    }
}
