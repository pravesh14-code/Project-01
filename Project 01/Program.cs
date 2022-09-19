using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    internal class Program
    {
        static void Main()
        {
            ConsoleLogger logger  = new ConsoleLogger ();

            logger.LogLine("My name is Pravesh Gowreea, a second-year Software Engineering Student at the University Of Mauritius.");

            CurriculumVitae curriculumVitae = new CurriculumVitae();
            curriculumVitae.displayMenu();

            ConditionFactory conditionFactory = new ConditionFactory();

            while (true)
            {
                logger.Log("\nMain Menu Choice => Select an appropriate choice to view more: ");
                int condition = int.Parse(Console.ReadLine());

                curriculumVitae = conditionFactory.Create(condition);
                curriculumVitae.displayDetail();
                curriculumVitae.displayMenu();
            }
        }
    }
}
