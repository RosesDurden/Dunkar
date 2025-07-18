// Services/MockDataService.cs
using Dunkar.Models;

namespace Dunkar.Services
{
    public class MockDataService
    {
        private static List<Team> _teams;
        private static List<Player> _players;
        private static List<Coach> _coaches;
        private static List<Game> _games;
        private static Season _currentSeason;

        static MockDataService()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            // Saison actuelle
            _currentSeason = new Season
            {
                Id = 1,
                Annee = 2025,
                DateDebut = new DateTime(2024, 10, 1),
                DateFin = new DateTime(2025, 6, 30),
                EstActive = true,
                NombreJournees = 82,
                PlafondSalarialGlobal = 140000000
            };

            // Équipes
            _teams = new List<Team>
            {
                new Team
                {
                    Id = 1,
                    Nom = "Lakers de Los Angeles",
                    Ville = "Los Angeles",
                    Abreviation = "LAL",
                    CouleurPrincipale = "#552583",
                    CouleurSecondaire = "#FDB927",
                    Statut = TeamStatus.Active,
                    Budget = 150000000,
                    PlafondSalarial = 140000000,
                    Joueurs = new List<Player>(),
                    SaisonsEquipe = new List<TeamSeason>
                    {
                        new TeamSeason { Saison = 2025, Victoires = 35, Defaites = 20, ClassementFinal = 4 }
                    }
                },
                new Team
                {
                    Id = 2,
                    Nom = "Warriors de Golden State",
                    Ville = "San Francisco",
                    Abreviation = "GSW",
                    CouleurPrincipale = "#1D428A",
                    CouleurSecondaire = "#FFC72C",
                    Statut = TeamStatus.Active,
                    Budget = 180000000,
                    PlafondSalarial = 140000000,
                    Joueurs = new List<Player>(),
                    SaisonsEquipe = new List<TeamSeason>
                    {
                        new TeamSeason { Saison = 2025, Victoires = 42, Defaites = 13, ClassementFinal = 1 }
                    }
                },
                new Team
                {
                    Id = 3,
                    Nom = "Celtics de Boston",
                    Ville = "Boston",
                    Abreviation = "BOS",
                    CouleurPrincipale = "#007A33",
                    CouleurSecondaire = "#BA9653",
                    Statut = TeamStatus.Active,
                    Budget = 165000000,
                    PlafondSalarial = 140000000,
                    Joueurs = new List<Player>(),
                    SaisonsEquipe = new List<TeamSeason>
                    {
                        new TeamSeason { Saison = 2025, Victoires = 40, Defaites = 15, ClassementFinal = 2 }
                    }
                },
                new Team
                {
                    Id = 4,
                    Nom = "Heat de Miami",
                    Ville = "Miami",
                    Abreviation = "MIA",
                    CouleurPrincipale = "#98002E",
                    CouleurSecondaire = "#F9A01B",
                    Statut = TeamStatus.Active,
                    Budget = 135000000,
                    PlafondSalarial = 140000000,
                    Joueurs = new List<Player>(),
                    SaisonsEquipe = new List<TeamSeason>
                    {
                        new TeamSeason { Saison = 2025, Victoires = 38, Defaites = 17, ClassementFinal = 3 }
                    }
                }
            };

            // Joueurs
            _players = new List<Player>
            {
                new Player
                {
                    Id = 1,
                    Prenom = "LeBron",
                    Nom = "James",
                    Age = 40,
                    Taille = 206,
                    Poids = 113,
                    PostePrincipal = Position.AilierFort,
                    PosteSecondaire = Position.AilierShooteur,
                    Nationalite = "USA",
                    Statut = PlayerStatus.Actif,
                    EquipeId = 1,
                    Stats = new PlayerStats
                    {
                        PointsParMatch = 25.2,
                        RebondsParMatch = 8.1,
                        PassesParMatch = 7.3,
                        InterceptionsParMatch = 1.2,
                        ContresParMatch = 0.8,
                        PourcentageTirs = 52.4,
                        PourcentageTroisPoints = 35.8,
                        MatchsJoues = 55
                    },
                    Attributs = new PlayerAttributes
                    {
                        Vitesse = 75, Force = 95, Endurance = 88, Agilite = 82,
                        TirPres = 90, TirMiDistance = 85, TirTroisPoints = 78,
                        Dribble = 88, Passe = 95, VisionDeJeu = 98,
                        RebondDefensif = 85, DefenseInterieure = 82,
                        Leadership = 99, NoteGlobale = 89
                    }
                },
                new Player
                {
                    Id = 2,
                    Prenom = "Stephen",
                    Nom = "Curry",
                    Age = 36,
                    Taille = 188,
                    Poids = 84,
                    PostePrincipal = Position.MeneurDeJeu,
                    Nationalite = "USA",
                    Statut = PlayerStatus.Actif,
                    EquipeId = 2,
                    Stats = new PlayerStats
                    {
                        PointsParMatch = 28.4,
                        RebondsParMatch = 4.2,
                        PassesParMatch = 6.8,
                        InterceptionsParMatch = 1.8,
                        ContresParMatch = 0.3,
                        PourcentageTirs = 48.2,
                        PourcentageTroisPoints = 42.7,
                        MatchsJoues = 52
                    },
                    Attributs = new PlayerAttributes
                    {
                        Vitesse = 85, Force = 65, Endurance = 90, Agilite = 92,
                        TirPres = 85, TirMiDistance = 95, TirTroisPoints = 99,
                        Dribble = 95, Passe = 90, VisionDeJeu = 92,
                        DefenseExterieure = 75, Leadership = 88, NoteGlobale = 92
                    }
                },
                new Player
                {
                    Id = 3,
                    Prenom = "Jayson",
                    Nom = "Tatum",
                    Age = 26,
                    Taille = 203,
                    Poids = 95,
                    PostePrincipal = Position.AilierShooteur,
                    PosteSecondaire = Position.AilierFort,
                    Nationalite = "USA",
                    Statut = PlayerStatus.Actif,
                    EquipeId = 3,
                    Stats = new PlayerStats
                    {
                        PointsParMatch = 26.8,
                        RebondsParMatch = 8.4,
                        PassesParMatch = 4.9,
                        InterceptionsParMatch = 1.1,
                        ContresParMatch = 0.6,
                        PourcentageTirs = 47.3,
                        PourcentageTroisPoints = 37.2,
                        MatchsJoues = 58
                    },
                    Attributs = new PlayerAttributes
                    {
                        Vitesse = 82, Force = 85, Endurance = 88, Agilite = 87,
                        TirPres = 88, TirMiDistance = 90, TirTroisPoints = 85,
                        Dribble = 85, Passe = 75, VisionDeJeu = 78,
                        DefenseExterieure = 82, Leadership = 75, NoteGlobale = 87
                    }
                },
                new Player
                {
                    Id = 4,
                    Prenom = "Jimmy",
                    Nom = "Butler",
                    Age = 35,
                    Taille = 201,
                    Poids = 104,
                    PostePrincipal = Position.AilierShooteur,
                    PosteSecondaire = Position.Arriere,
                    Nationalite = "USA",
                    Statut = PlayerStatus.Actif,
                    EquipeId = 4,
                    Stats = new PlayerStats
                    {
                        PointsParMatch = 22.1,
                        RebondsParMatch = 6.2,
                        PassesParMatch = 5.8,
                        InterceptionsParMatch = 2.1,
                        ContresParMatch = 0.4,
                        PourcentageTirs = 49.8,
                        PourcentageTroisPoints = 31.5,
                        MatchsJoues = 45
                    },
                    Attributs = new PlayerAttributes
                    {
                        Vitesse = 80, Force = 88, Endurance = 92, Agilite = 85,
                        TirPres = 82, TirMiDistance = 78, TirTroisPoints = 70,
                        Dribble = 82, Passe = 78, VisionDeJeu = 80,
                        DefenseExterieure = 95, Leadership = 90, NoteGlobale = 85
                    }
                },
                new Player
                {
                    Id = 5,
                    Prenom = "Anthony",
                    Nom = "Davis",
                    Age = 31,
                    Taille = 211,
                    Poids = 115,
                    PostePrincipal = Position.AilierFort,
                    PosteSecondaire = Position.Pivot,
                    Nationalite = "USA",
                    Statut = PlayerStatus.Blesse,
                    EquipeId = 1,
                    Stats = new PlayerStats
                    {
                        PointsParMatch = 24.6,
                        RebondsParMatch = 11.2,
                        PassesParMatch = 3.1,
                        InterceptionsParMatch = 1.3,
                        ContresParMatch = 2.8,
                        PourcentageTirs = 54.2,
                        PourcentageTroisPoints = 28.9,
                        MatchsJoues = 38
                    },
                    Attributs = new PlayerAttributes
                    {
                        Vitesse = 75, Force = 92, Endurance = 80, Agilite = 78,
                        TirPres = 88, TirMiDistance = 82, TirTroisPoints = 65,
                        RebondDefensif = 95, RebondOffensif = 88,
                        DefenseInterieure = 95, Contre = 92, NoteGlobale = 88
                    }
                },
                new Player
                {
                    Id = 6,
                    Prenom = "Klay",
                    Nom = "Thompson",
                    Age = 34,
                    Taille = 198,
                    Poids = 98,
                    PostePrincipal = Position.Arriere,
                    PosteSecondaire = Position.AilierShooteur,
                    Nationalite = "USA",
                    Statut = PlayerStatus.Actif,
                    EquipeId = 2,
                    Stats = new PlayerStats
                    {
                        PointsParMatch = 21.9,
                        RebondsParMatch = 4.1,
                        PassesParMatch = 2.4,
                        InterceptionsParMatch = 0.9,
                        ContresParMatch = 0.4,
                        PourcentageTirs = 45.8,
                        PourcentageTroisPoints = 41.3,
                        MatchsJoues = 55
                    },
                    Attributs = new PlayerAttributes
                    {
                        Vitesse = 78, Force = 75, Endurance = 85, Agilite = 80,
                        TirPres = 82, TirMiDistance = 92, TirTroisPoints = 95,
                        DefenseExterieure = 88, NoteGlobale = 84
                    }
                }
            };

            // Associer les joueurs aux équipes
            foreach (var player in _players)
            {
                var team = _teams.FirstOrDefault(t => t.Id == player.EquipeId);
                if (team != null)
                {
                    player.Equipe = team;
                    team.Joueurs.Add(player);
                }
            }

            // Matchs
            _games = new List<Game>
            {
                new Game
                {
                    Id = 1,
                    EquipeDomicileId = 1,
                    EquipeExterieurId = 2,
                    DateMatch = DateTime.Now.AddDays(2),
                    EstTermine = false,
                    TypeChampionnat = ChampionshipType.Regulier,
                    Saison = 2025,
                    Journee = 56
                },
                new Game
                {
                    Id = 2,
                    EquipeDomicileId = 3,
                    EquipeExterieurId = 4,
                    DateMatch = DateTime.Now.AddDays(-1),
                    ScoreDomicile = 112,
                    ScoreExterieur = 108,
                    EstTermine = true,
                    TypeChampionnat = ChampionshipType.Regulier,
                    Saison = 2025,
                    Journee = 55
                },
                new Game
                {
                    Id = 3,
                    EquipeDomicileId = 2,
                    EquipeExterieurId = 3,
                    DateMatch = DateTime.Now.AddDays(5),
                    EstTermine = false,
                    TypeChampionnat = ChampionshipType.Regulier,
                    Saison = 2025,
                    Journee = 57
                }
            };

            // Associer les équipes aux matchs
            foreach (var game in _games)
            {
                game.EquipeDomicile = _teams.First(t => t.Id == game.EquipeDomicileId);
                game.EquipeExterieur = _teams.First(t => t.Id == game.EquipeExterieurId);
            }
        }

        public List<Team> GetTeams() => _teams;
        public List<Player> GetPlayers() => _players;
        public List<Coach> GetCoaches() => _coaches ?? new List<Coach>();
        public List<Game> GetGames() => _games;
        public Season GetCurrentSeason() => _currentSeason;

        public Team? GetTeamById(int id) => _teams.FirstOrDefault(t => t.Id == id);
        public Player? GetPlayerById(int id) => _players.FirstOrDefault(p => p.Id == id);
        public Game? GetGameById(int id) => _games.FirstOrDefault(g => g.Id == id);
    }
}