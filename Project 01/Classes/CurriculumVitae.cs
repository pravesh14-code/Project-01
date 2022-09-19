using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    public class CurriculumVitae : IMenu ,IDetail
    {
        public ConsoleLogger logger = new ConsoleLogger();
        
        enum category { Experience = 1, Education  = 2 , PersonalSkills = 3 , TechnologicalSkills = 4 , ContactDetails = 5 };
        public void displayMenu()
        {
            logger.LogLine("     \n\n************* Curriculum Vitae Main Menu *************\n");

            foreach (var i in Enum.GetValues(typeof(category)))
            {
                logger.LogLine((int)i + ": " + i);
            }
        }
        public virtual void displayDetail() => new NotImplementedException();
    }
}
