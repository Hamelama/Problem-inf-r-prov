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

        public PupilList(int current)
        {
            currentPos = current;
        }

        public void AddPupil(Pupil pupil)
        {
            //Index minus 1
            if (currentPos >= (pupils.Count() - 1))
            {
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
