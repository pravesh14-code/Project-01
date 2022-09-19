using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Classes
{
    public class TechnologicalSkills : CurriculumVitae
    {
        public override void displayDetail()
        {
            logger.LogLine("\n********* Technological Skills *********\n");
            logger.LogLine("Microsoft Office Tools, Adobe Photoshop, Adobe After Effects, Dart, " +
                "\nHTML, CSS, JavaScript, PHP, SQL, Java, C++, C#.");
        }
    }
}
