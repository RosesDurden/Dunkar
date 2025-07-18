namespace Dunkar.Models
{
    // Énumération pour les postes de basket
    public enum Position
    {
        MeneurDeJeu,    // Point Guard (PG)
        Arriere,  // Shooting Guard (SG)
        AilierShooteur,         // Small Forward (SF)
        AilierFort,     // Power Forward (PF)
        Pivot           // Center (C)
    }

    // Énumération pour les statuts des joueurs
    public enum PlayerStatus
    {
        Actif,
        Blesse,
        Suspendu,
        Retire,
        Transfere
    }

    // Énumération pour les types de championnats
    public enum ChampionshipType
    {
        Regulier,
        Playoffs,
        Coupe,
        International
    }

    // Énumération pour les statuts d'équipe
    public enum TeamStatus
    {
        Active,
        Inactive,
        Relegation,
        Qualification
    }
}
