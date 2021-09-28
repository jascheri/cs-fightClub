namespace FightClub.Equiptment
{
    public class Equiptment : ILevel
    {
        public int MyLevel { get; set; }
        public int MyExperience = 0;

        public int AddExperience(int experiencePoints)
        {
            if ((MyExperience += experiencePoints) > MyExperience)
            {
                MyExperience -= Constants.LevelUpRequirements[MyLevel];
                MyLevel++;
                UpdateStats();
            }
            return MyLevel;
        }

        private void UpdateStats() { }
    }
}