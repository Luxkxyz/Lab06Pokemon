using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Pokemon.Resources
{
    public class Pokemon
    {
        protected int id;
        protected string name;
        protected string pic;
        protected int level;
        protected PokemonType type;
        protected PokemonAbilities abilities;
        protected int Hp;
        protected int Atk;
        protected int Def;
        protected int SpAtk;
        protected int SDef;
        protected int Speed;


        public string Name()
        {
            return name;

        }
    }
    public enum PokemonType
    {
        Grass, Poison, Electr, Fire, Water, Dragon
    }
    public enum PokemonAbilities
    {
        Overgrow, chlophyll, Static, lightning, Blaze, Solar_Power, Torrent, Rain_Dish, Inner_Focus, Infiltrator, Rock_Head, Sheer_Force
    }
}
