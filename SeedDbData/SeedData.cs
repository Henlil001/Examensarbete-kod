﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedDbData
{
    public static class SeedData
    {
        public static List<HockeyPlayer> GetSeedData()
        {
            return new List<HockeyPlayer>
        {
            new HockeyPlayer { FullName = "Henrik Zetterberg", HightInCm = 180, WeightInKg = 88, Club = "Detroit Red Wings", Position = "Center", Age = 43 },
            new HockeyPlayer { FullName = "Nicklas Lidström", HightInCm = 185, WeightInKg = 90, Club = "Detroit Red Wings", Position = "Defense", Age = 54 },
            new HockeyPlayer { FullName = "Peter Forsberg", HightInCm = 183, WeightInKg = 92, Club = "Colorado Avalanche", Position = "Center", Age = 51 },
            new HockeyPlayer { FullName = "Mats Sundin", HightInCm = 191, WeightInKg = 100, Club = "Toronto Maple Leafs", Position = "Center", Age = 53 },
            new HockeyPlayer { FullName = "Victor Hedman", HightInCm = 198, WeightInKg = 103, Club = "Tampa Bay Lightning", Position = "Defense", Age = 33 },
            new HockeyPlayer { FullName = "Erik Karlsson", HightInCm = 180, WeightInKg = 85, Club = "Pittsburgh Penguins", Position = "Defense", Age = 33 },
            new HockeyPlayer { FullName = "Daniel Sedin", HightInCm = 182, WeightInKg = 88, Club = "Vancouver Canucks", Position = "Left Wing", Age = 43 },
            new HockeyPlayer { FullName = "Henrik Sedin", HightInCm = 182, WeightInKg = 88, Club = "Vancouver Canucks", Position = "Center", Age = 43 },
            new HockeyPlayer { FullName = "Patrik Berglund", HightInCm = 193, WeightInKg = 100, Club = "St. Louis Blues", Position = "Center", Age = 35 },
            new HockeyPlayer { FullName = "Filip Forsberg", HightInCm = 188, WeightInKg = 92, Club = "Nashville Predators", Position = "Left Wing", Age = 29 },
            new HockeyPlayer { FullName = "Gabriel Landeskog", HightInCm = 185, WeightInKg = 95, Club = "Colorado Avalanche", Position = "Left Wing", Age = 31 },
            new HockeyPlayer { FullName = "William Nylander", HightInCm = 183, WeightInKg = 87, Club = "Toronto Maple Leafs", Position = "Right Wing", Age = 27 },
            new HockeyPlayer { FullName = "Elias Pettersson", HightInCm = 188, WeightInKg = 84, Club = "Vancouver Canucks", Position = "Center", Age = 25 },
            new HockeyPlayer { FullName = "Rasmus Dahlin", HightInCm = 191, WeightInKg = 94, Club = "Buffalo Sabres", Position = "Defense", Age = 24 },
            new HockeyPlayer { FullName = "Jacob Markström", HightInCm = 191, WeightInKg = 88, Club = "Calgary Flames", Position = "Goalie", Age = 34 },
            new HockeyPlayer { FullName = "Robin Lehner", HightInCm = 192, WeightInKg = 105, Club = "Vegas Golden Knights", Position = "Goalie", Age = 33 },
            new HockeyPlayer { FullName = "Alexander Edler", HightInCm = 193, WeightInKg = 97, Club = "Los Angeles Kings", Position = "Defense", Age = 38 },
            new HockeyPlayer { FullName = "Oscar Lindberg", HightInCm = 185, WeightInKg = 92, Club = "Vegas Golden Knights", Position = "Center", Age = 32 },
            new HockeyPlayer { FullName = "Carl Hagelin", HightInCm = 180, WeightInKg = 85, Club = "Washington Capitals", Position = "Left Wing", Age = 35 },
            new HockeyPlayer { FullName = "Marcus Johansson", HightInCm = 183, WeightInKg = 86, Club = "Minnesota Wild", Position = "Left Wing", Age = 33 },
            new HockeyPlayer { FullName = "Johan Larsson", HightInCm = 181, WeightInKg = 88, Club = "Arizona Coyotes", Position = "Center", Age = 32 },
            new HockeyPlayer { FullName = "André Burakovsky", HightInCm = 188, WeightInKg = 86, Club = "Seattle Kraken", Position = "Left Wing", Age = 29 },
            new HockeyPlayer { FullName = "Jesper Bratt", HightInCm = 180, WeightInKg = 84, Club = "New Jersey Devils", Position = "Left Wing", Age = 26 },
            new HockeyPlayer { FullName = "Jonathan Eriksson", HightInCm = 185, WeightInKg = 89, Club = "AIK", Position = "Right Wing", Age = 28 },
            new HockeyPlayer { FullName = "Kevin Sandberg", HightInCm = 190, WeightInKg = 95, Club = "HV71", Position = "Defense", Age = 27 },
            new HockeyPlayer { FullName = "Linus Karlsson", HightInCm = 178, WeightInKg = 82, Club = "Färjestad", Position = "Center", Age = 26 },
            new HockeyPlayer { FullName = "Max Nylander", HightInCm = 183, WeightInKg = 86, Club = "Luleå", Position = "Left Wing", Age = 29 },
            new HockeyPlayer { FullName = "Simon Holm", HightInCm = 192, WeightInKg = 100, Club = "Frölunda", Position = "Defense", Age = 30 },
            new HockeyPlayer { FullName = "Oscar Lindqvist", HightInCm = 181, WeightInKg = 84, Club = "Djurgården", Position = "Right Wing", Age = 25 },
            new HockeyPlayer { FullName = "Tobias Berg", HightInCm = 186, WeightInKg = 88, Club = "Linköping", Position = "Center", Age = 27 },
            new HockeyPlayer { FullName = "Hampus Dahl", HightInCm = 190, WeightInKg = 96, Club = "Brynäs", Position = "Defense", Age = 28 },
            new HockeyPlayer { FullName = "Viktor Fors", HightInCm = 184, WeightInKg = 90, Club = "Malmö Redhawks", Position = "Left Wing", Age = 26 },
            new HockeyPlayer { FullName = "Jesper Ek", HightInCm = 179, WeightInKg = 80, Club = "Rögle", Position = "Right Wing", Age = 24 },
            new HockeyPlayer { FullName = "Alexander Nylander", HightInCm = 182, WeightInKg = 87, Club = "Buffalo Sabres", Position = "Right Wing", Age = 25 },
            new HockeyPlayer { FullName = "Fredrik Claesson", HightInCm = 180, WeightInKg = 85, Club = "New York Rangers", Position = "Defense", Age = 31 },
            new HockeyPlayer { FullName = "Jesper Olofsson", HightInCm = 185, WeightInKg = 90, Club = "Skellefteå AIK", Position = "Left Wing", Age = 28 },
            new HockeyPlayer { FullName = "Kalle Kossila", HightInCm = 177, WeightInKg = 80, Club = "AHL", Position = "Center", Age = 27 },
            new HockeyPlayer { FullName = "Sebastian Aho", HightInCm = 184, WeightInKg = 89, Club = "Carolina Hurricanes", Position = "Defense", Age = 27 },
            new HockeyPlayer { FullName = "Oskar Nilsson", HightInCm = 179, WeightInKg = 84, Club = "Leksands IF", Position = "Right Wing", Age = 25 },
            new HockeyPlayer { FullName = "Jonas Brodin", HightInCm = 185, WeightInKg = 90, Club = "Minnesota Wild", Position = "Defense", Age = 30 },
            new HockeyPlayer { FullName = "Max Friberg", HightInCm = 182, WeightInKg = 85, Club = "Växjö Lakers", Position = "Left Wing", Age = 28 },
            new HockeyPlayer { FullName = "Jimmie Ericsson", HightInCm = 183, WeightInKg = 88, Club = "Luleå", Position = "Center", Age = 35 },
            new HockeyPlayer { FullName = "David Rundblad", HightInCm = 185, WeightInKg = 92, Club = "Chicago Blackhawks", Position = "Defense", Age = 32 },
            new HockeyPlayer { FullName = "Anton Lander", HightInCm = 183, WeightInKg = 88, Club = "Edmonton Oilers", Position = "Center", Age = 33 },
            new HockeyPlayer { FullName = "Viktor Arvidsson", HightInCm = 175, WeightInKg = 75, Club = "Los Angeles Kings", Position = "Right Wing", Age = 30 },
            new HockeyPlayer { FullName = "Linus Ullmark", HightInCm = 191, WeightInKg = 100, Club = "Boston Bruins", Position = "Goalie", Age = 29 },
            new HockeyPlayer { FullName = "Mattias Ekholm", HightInCm = 191, WeightInKg = 93, Club = "Nashville Predators", Position = "Defense", Age = 33 },
            new HockeyPlayer { FullName = "Jakob Silfverberg", HightInCm = 185, WeightInKg = 88, Club = "Anaheim Ducks", Position = "Right Wing", Age = 33 },
            new HockeyPlayer { FullName = "Erik Gustafsson", HightInCm = 181, WeightInKg = 83, Club = "Washington Capitals", Position = "Defense", Age = 31 },
            new HockeyPlayer { FullName = "Oskar Möller", HightInCm = 179, WeightInKg = 81, Club = "Los Angeles Kings", Position = "Left Wing", Age = 30 },
            new HockeyPlayer { FullName = "Lias Andersson", HightInCm = 183, WeightInKg = 85, Club = "Los Angeles Kings", Position = "Center", Age = 25 },
            new HockeyPlayer { FullName = "Jonathan Dahlén", HightInCm = 180, WeightInKg = 82, Club = "San Jose Sharks", Position = "Left Wing", Age = 26 },
            new HockeyPlayer { FullName = "Joel Lundqvist", HightInCm = 181, WeightInKg = 84, Club = "Frölunda", Position = "Center", Age = 42 },
            new HockeyPlayer { FullName = "Victor Rask", HightInCm = 183, WeightInKg = 91, Club = "Minnesota Wild", Position = "Center", Age = 26 },
            new HockeyPlayer { FullName = "Anders Nilsson", HightInCm = 196, WeightInKg = 105, Club = "Ottawa Senators", Position = "Goalie", Age = 33 },
            new HockeyPlayer { FullName = "Jacob Trouba", HightInCm = 188, WeightInKg = 99, Club = "New York Rangers", Position = "Defense", Age = 30 },
            new HockeyPlayer { FullName = "Marcus Pettersson", HightInCm = 190, WeightInKg = 87, Club = "Pittsburgh Penguins", Position = "Defense", Age = 27 },
            new HockeyPlayer { FullName = "Daniel Sprong", HightInCm = 180, WeightInKg = 85, Club = "Seattle Kraken", Position = "Right Wing", Age = 25 },
            new HockeyPlayer { FullName = "David Pastrňák", HightInCm = 188, WeightInKg = 91, Club = "Boston Bruins", Position = "Right Wing", Age = 27 },
            new HockeyPlayer { FullName = "Rasmus Ristolainen", HightInCm = 191, WeightInKg = 103, Club = "Philadelphia Flyers", Position = "Defense", Age = 30 },
            new HockeyPlayer { FullName = "Jesper Fast", HightInCm = 180, WeightInKg = 85, Club = "Carolina Hurricanes", Position = "Right Wing", Age = 32 },
            new HockeyPlayer { FullName = "Magnus Hellberg", HightInCm = 196, WeightInKg = 97, Club = "Detroit Red Wings", Position = "Goalie", Age = 32 },
            new HockeyPlayer { FullName = "Olli Määttä", HightInCm = 186, WeightInKg = 93, Club = "Los Angeles Kings", Position = "Defense", Age = 29 },
            new HockeyPlayer { FullName = "Albin Eriksson", HightInCm = 185, WeightInKg = 88, Club = "Färjestad", Position = "Center", Age = 28 },
            new HockeyPlayer { FullName = "Victor Olofsson", HightInCm = 180, WeightInKg = 84, Club = "Buffalo Sabres", Position = "Left Wing", Age = 27 },
            new HockeyPlayer { FullName = "Jesper Wallstedt", HightInCm = 191, WeightInKg = 92, Club = "Minnesota Wild", Position = "Goalie", Age = 21 },
            new HockeyPlayer { FullName = "Oskar Sundqvist", HightInCm = 190, WeightInKg = 97, Club = "Detroit Red Wings", Position = "Center", Age = 29 },
            new HockeyPlayer { FullName = "Erik Haula", HightInCm = 183, WeightInKg = 84, Club = "New Jersey Devils", Position = "Center", Age = 33 },
            new HockeyPlayer { FullName = "Anton Forsberg", HightInCm = 188, WeightInKg = 90, Club = "Ottawa Senators", Position = "Goalie", Age = 31 },
            new HockeyPlayer { FullName = "Marcus Sorensen", HightInCm = 177, WeightInKg = 79, Club = "San Jose Sharks", Position = "Left Wing", Age = 31 },
            new HockeyPlayer { FullName = "Hampus Lindholm", HightInCm = 188, WeightInKg = 98, Club = "Boston Bruins", Position = "Defense", Age = 29 },
            new HockeyPlayer { FullName = "Lukas Bengtsson", HightInCm = 182, WeightInKg = 85, Club = "Malmö Redhawks", Position = "Defense", Age = 25 },
            new HockeyPlayer { FullName = "William Eklund", HightInCm = 180, WeightInKg = 82, Club = "San Jose Sharks", Position = "Left Wing", Age = 21 },
            new HockeyPlayer { FullName = "Karl Klingberg", HightInCm = 185, WeightInKg = 87, Club = "Örebro HK", Position = "Right Wing", Age = 26 },
            new HockeyPlayer { FullName = "Daniel Tjärnqvist", HightInCm = 182, WeightInKg = 85, Club = "Växjö Lakers", Position = "Defense", Age = 30 },
            new HockeyPlayer { FullName = "Jacob de la Rose", HightInCm = 191, WeightInKg = 93, Club = "Detroit Red Wings", Position = "Center", Age = 28 },
            new HockeyPlayer { FullName = "Olle Lycksell", HightInCm = 179, WeightInKg = 82, Club = "Linköping", Position = "Center", Age = 24 },
            new HockeyPlayer { FullName = "Simon Olofsson", HightInCm = 187, WeightInKg = 90, Club = "Frölunda", Position = "Left Wing", Age = 27 },
            new HockeyPlayer { FullName = "Sebastian Karlsson", HightInCm = 183, WeightInKg = 84, Club = "Luleå", Position = "Right Wing", Age = 26 },
            new HockeyPlayer { FullName = "Mattias Janmark", HightInCm = 188, WeightInKg = 85, Club = "Vegas Golden Knights", Position = "Left Wing", Age = 31 },
            new HockeyPlayer { FullName = "Henrik Tommernes", HightInCm = 185, WeightInKg = 86, Club = "Malmö Redhawks", Position = "Defense", Age = 33 },
            new HockeyPlayer { FullName = "Erik Andersson", HightInCm = 180, WeightInKg = 83, Club = "HV71", Position = "Center", Age = 28 },
            new HockeyPlayer { FullName = "Victor Hedlund", HightInCm = 190, WeightInKg = 92, Club = "AIK", Position = "Defense", Age = 25 },
            new HockeyPlayer { FullName = "Johan Andersson", HightInCm = 184, WeightInKg = 88, Club = "Växjö Lakers", Position = "Right Wing", Age = 29 },
            new HockeyPlayer { FullName = "Oscar Persson", HightInCm = 182, WeightInKg = 85, Club = "Örebro HK", Position = "Defense", Age = 27 },
            new HockeyPlayer { FullName = "Alexander Forsberg", HightInCm = 190, WeightInKg = 93, Club = "Frölunda", Position = "Center", Age = 28 },
            new HockeyPlayer { FullName = "Joel Lundström", HightInCm = 179, WeightInKg = 81, Club = "Skellefteå AIK", Position = "Left Wing", Age = 26 },
            new HockeyPlayer { FullName = "David Bergström", HightInCm = 183, WeightInKg = 87, Club = "Luleå", Position = "Defense", Age = 30 },
            new HockeyPlayer { FullName = "Albin Molin", HightInCm = 185, WeightInKg = 89, Club = "Malmö Redhawks", Position = "Right Wing", Age = 27 },
            new HockeyPlayer { FullName = "Marcus Dahl", HightInCm = 189, WeightInKg = 94, Club = "Djurgården", Position = "Center", Age = 32 },
            new HockeyPlayer { FullName = "Rasmus Sandin", HightInCm = 183, WeightInKg = 84, Club = "Toronto Maple Leafs", Position = "Defense", Age = 23 },
            new HockeyPlayer { FullName = "Sebastian Stålberg", HightInCm = 180, WeightInKg = 82, Club = "MODO Hockey", Position = "Center", Age = 29 },
            new HockeyPlayer { FullName = "Victor Björk", HightInCm = 187, WeightInKg = 91, Club = "Brynäs", Position = "Left Wing", Age = 28 },
            new HockeyPlayer { FullName = "Maxim Matushkin", HightInCm = 190, WeightInKg = 95, Club = "SKA Saint Petersburg", Position = "Defense", Age = 28 },
            new HockeyPlayer { FullName = "Lukas Radil", HightInCm = 185, WeightInKg = 91, Club = "San Jose Sharks", Position = "Left Wing", Age = 32 },
            new HockeyPlayer { FullName = "Christian Folin", HightInCm = 191, WeightInKg = 99, Club = "Los Angeles Kings", Position = "Defense", Age = 33 },
            new HockeyPlayer { FullName = "Filip Sandberg", HightInCm = 182, WeightInKg = 86, Club = "Växjö Lakers", Position = "Right Wing", Age = 27 },
            new HockeyPlayer { FullName = "Isak Wallin", HightInCm = 178, WeightInKg = 80, Club = "Östersund", Position = "Center", Age = 26 },
            new HockeyPlayer { FullName = "Sebastian Strandberg", HightInCm = 180, WeightInKg = 85, Club = "Luleå", Position = "Right Wing", Age = 29 },
            new HockeyPlayer { FullName = "Mikael Wikstrand", HightInCm = 186, WeightInKg = 91, Club = "Frölunda", Position = "Defense", Age = 30 },
            new HockeyPlayer { FullName = "Erik Törnqvist", HightInCm = 187, WeightInKg = 92, Club = "Brynäs", Position = "Center", Age = 28 },
        };
        }
    }
}
