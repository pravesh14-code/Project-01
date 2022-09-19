using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Classes
{
    public class ContactDetails : CurriculumVitae
    {
        public override void displayDetail()
        {
            logger.LogLine("\n********* Contact Details *********\n");
            logger.LogLine("Phone Number : 5783 3020 \nAddress : Royal Road Carreau Accacia.");
        }
    }
}
