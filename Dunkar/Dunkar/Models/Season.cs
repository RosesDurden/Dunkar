namespace Dunkar.Models
{
    // Modèle pour la saison actuelle (configuration globale)
    public class Season
    {
        public int Id { get; set; }

        public int Annee { get; set; }

        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public bool EstActive { get; set; }

        public int NombreJournees { get; set; }

        public int PlafondSalarialGlobal { get; set; }

        public DateTime DateCreation { get; set; }
    }
}
