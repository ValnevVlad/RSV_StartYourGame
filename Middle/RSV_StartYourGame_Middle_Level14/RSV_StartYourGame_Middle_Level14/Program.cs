using System;
using System.Diagnostics;

namespace RSV_StartYourGame_Middle_Level14
{
    class MainClass
    {
        //Test1
        //static private float base_damage = 113;
        //static private float power = 57;
        //static private float kus = 0.06f; // 6%
        //static private float ability_level = 5;
        //static private float basic_increase_damage_from_passive_ability = 1.65f; //165%
        //static private float increase_damage_from_passive_ability = 0.12f; //12%
        //static private float passive_ability = 5;

        //Test2
        //static private float base_damage = 44;
        //static private float power = 96;
        //static private float kus = 0.26f; // 6%
        //static private float ability_level = 2;
        //static private float basic_increase_damage_from_passive_ability = 1.72f; //165%
        //static private float increase_damage_from_passive_ability = 0.54f; //12%
        //static private float passive_ability = 7;

        //Test3
        static private float base_damage = 137;
        static private float power = 39;
        static private float kus = 0.36f; // 6%
        static private float ability_level = 8;
        static private float basic_increase_damage_from_passive_ability = 1.41f; //165%
        static private float increase_damage_from_passive_ability = 0.66f; //12%
        static private float passive_ability = 9;


        static private float kus_damage;
        static private float koef_passive_ability;

        public static void Main()
        {
            kus_damage = power * (ability_level-1) * kus;
            koef_passive_ability = basic_increase_damage_from_passive_ability + (passive_ability-1) * increase_damage_from_passive_ability;

            float damage = (base_damage + power + kus_damage) * koef_passive_ability;
            Console.Write(damage);
        }
    }
}
