﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.Model.Transformers
{
    class ChampionIdToName
    {
        public static string GetName(long id)
        {
            string value;
            dict.TryGetValue(id,out value);

            return value;
        }

        private static Dictionary<long, string> dict = new Dictionary<long, string>()
        {
            { 1,"Annie" },
            { 10,"Kayle" },
            { 101,"Xerath" },
            { 102,"Shyvana" },
            { 103,"Ahri" },
            { 104,"Graves" },
            { 105,"Fizz" },
            { 106,"Volibear" },
            { 107,"Rengar" },
            { 11,"Master Yi" },
            { 110,"Varus" },
            { 111,"Nautilus" },
            { 112,"Viktor" },
            { 113,"Sejuani" },
            { 114,"Fiora" },
            { 115,"Ziggs" },
            { 117,"Lulu" },
            { 119,"Draven" },
            { 12,"Alistar" },
            { 120,"Hecarim" },
            { 121,"Kha'Zix" },
            { 122,"Darius" },
            { 126,"Jayce" },
            { 127,"Lissandra" },
            { 13,"Ryze" },
            { 131,"Diana" },
            { 133,"Quinn" },
            { 134,"Syndra" },
            { 136,"Aurelion Sol" },
            { 14,"Sion" },
            { 143,"Zyra" },
            { 15,"Sivir" },
            { 150,"Gnar" },
            { 154,"Zac" },
            { 157,"Yasuo" },
            { 16,"Soraka" },
            { 161,"Vel'Koz" },
            { 163,"Taliyah" },
            { 164,"Camille" },
            { 17,"Teemo" },
            { 18,"Tristana" },
            { 19,"Warwick" },
            { 2,"Olaf" },
            { 20,"Nunu" },
            { 201,"Braum" },
            { 202,"Jhin" },
            { 203,"Kindred" },
            { 21,"Miss Fortune" },
            { 22,"Ashe" },
            { 222,"Jinx" },
            { 223,"Tahm Kench" },
            { 23,"Tryndamere" },
            { 236,"Lucian" },
            { 238,"Zed" },
            { 24,"Jax" },
            { 240,"Kled" },
            { 245,"Ekko" },
            { 25,"Morgana" },
            { 254,"Vi" },
            { 26,"Zilean" },
            { 266,"Aatrox" },
            { 267,"Nami" },
            { 268,"Azir" },
            { 27,"Singed" },
            { 28,"Evelyn" },
            { 29,"Twitch" },
            { 3,"Galio" },
            { 30,"Karthus" },
            { 31,"Cho'Gath" },
            { 32,"Amumu" },
            { 33,"Rammus" },
            { 34,"Anivia" },
            { 35,"Shaco" },
            { 36,"Dr. Mundo" },
            { 37,"Sona" },
            { 38,"Kassadin" },
            { 39,"Irelia" },
            { 4,"Twisted Fate" },
            { 40,"Janna" },
            { 41,"Gangplank" },
            { 412,"Thresh" },
            { 42,"Corki" },
            { 420,"Illaoi" },
            { 421,"Rek'Sai" },
            { 427,"Ivern" },
            { 429,"Kalista" },
            { 43,"Karma" },
            { 432,"Bard" },
            { 44,"Taric" },
            { 45,"Veigar" },
            { 48,"Trundle" },
            { 5,"Xin Zhao" },
            { 50,"Swain" },
            { 51,"Caitlyn" },
            { 53,"Blitzcrank" },
            { 54,"Maplhite" },
            { 55,"Katarina" },
            { 56,"Nocturne" },
            { 57,"Maokai" },
            { 58,"Renekton" },
            { 59,"Jarvan IV" },
            { 6,"Urgot" },
            { 60,"Elise" },
            { 61,"Orianna" },
            { 62,"Wukong" },
            { 63,"Brand" },
            { 64,"Lee Sin" },
            { 67,"Vayne" },
            { 68,"Rumble" },
            { 69,"Cassiopeia" },
            { 7,"LeBlanc" },
            { 72,"Skarner" },
            { 74,"Heimerdinger" },
            { 75,"Nasus" },
            { 76,"Nidalee" },
            { 77,"Udyr" },
            { 78,"Poppy" },
            { 79,"Gragas" },
            { 8,"Vladimir" },
            { 80,"Pantheon" },
            { 81,"Ezreal" },
            { 82,"Mordekaiser" },
            { 83,"Yorick" },
            { 84,"Akali" },
            { 85,"Kennen" },
            { 86,"Garen" },
            { 89,"Leona" },
            { 9,"Fiddlesticks" },
            { 90,"Malzahar" },
            { 91,"Talon" },
            { 92,"Riven" },
            { 96,"Kog'Maw" },
            { 98,"Shen" },
            { 99,"Lux" },
        };
    }
}
