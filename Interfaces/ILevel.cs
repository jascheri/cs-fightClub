namespace FightClub.Equiptment
{
    internal interface ILevel
    {
        private int MyLevel { 
            get 
            { 
                return MyLevel; 
            } 
            set
            {
            }
         }
        /// <summary>
        /// Adds experience to the object and handles the levelup where applicable.  Returns the new level if leveled up or 0
        /// </summary>
        /// <param name="experiencePoints">Experience points sent to the object</param>
        public int AddExperience(int experiencePoints);

        
    }
}