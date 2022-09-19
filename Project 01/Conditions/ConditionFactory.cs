using Project_01.Classes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    public class ConditionFactory
    {
        ConsoleLogger logger = new ConsoleLogger();
        public CurriculumVitae Create (int choice)
        {
            switch (choice)
            {
                case 1:  return new Experience();

                case 2:  return new Education();

                case 3:  return new PersonalSkills();
                    
                case 4:  return new TechnologicalSkills();
                   
                case 5:  return new ContactDetails();

            }
            logger.LogLine("Error!! Please select appropraite choice!!");
            return new CurriculumVitae() ;
        }
    }
}
