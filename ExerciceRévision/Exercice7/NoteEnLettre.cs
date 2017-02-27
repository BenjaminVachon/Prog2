using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7
{
    class NoteEnLettre
    {
        public int note;

        public NoteEnLettre(int note)
        {
            this.note = note;
        }

        public char Lettre()
        {
            if (note >= 90)
            {
                return 'A';
            }
            else if (note >= 80)
            {
                return 'B';
            }
            else if (note >= 70)
            {
                return 'C';
            }
            else if (note >= 60)
            {
                return 'D';
            }
            else
            {
                return 'E';
            }
        }
    }
}
