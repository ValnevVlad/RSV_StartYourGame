using System;

namespace Vampirism
{
    class StartYourGameTraineeLevel
    {
        private static float Vampirism_Exchange_Coeff = 81;
        private static float Weapon_Vampirism_Rating = 4;
        private static float Armor_VampirismRating = 0;
        private static float Bracers_Vampirism_Rating = 5;
        private static float Leggins_Vampirism_Rating = 0;
        private static float TotalDamage = 40;

        public static void Main(string[] args)
        {
            float VampirismRating = Weapon_Vampirism_Rating + Armor_VampirismRating + Bracers_Vampirism_Rating + Leggins_Vampirism_Rating;
            float VampirismPoints = VampirismRating * Vampirism_Exchange_Coeff;
            float TotalVampirism = VampirismPoints * TotalDamage / 100;
            Console.WriteLine(VampirismPoints);
            Console.WriteLine(VampirismRating);
            Console.WriteLine(TotalVampirism);
        }
    }
}