using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_inför_prov
{
    class PupilList
    {
        public int currentPos;
        public List<Pupil> pupils = new List<Pupil>();

        public PupilList()
        {
            currentPos = 0;
        }

        public void AddPupil(Pupil pupil)
        {
           
            if (currentPos == pupils.Count())
            {
                //Om nuvarande positiobn är lika lång som listan, så är den nya positionen
                //samma index som positionen. Om listan innehåller 4 så är nytt idnex 4 (fast det
                //blir ju den 5:e eleven, men index börjar på 0
                pupils.Insert(currentPos, pupil);
            }
            else
            {
                currentPos++;
                pupils.Insert(currentPos, pupil);
                
            }

            
        }
    }
}
