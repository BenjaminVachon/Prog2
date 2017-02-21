using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRévision19
{
    class Jeux
    {
        public string[] message = new string[8];
        public string messageShown;
        public int resultat;
        public int nb1, nb2;
        Random rng = new Random();

        public Jeux()
        {
            message[0] = "Très bien !";
            message[1] = "Excellent!";
            message[2] = "Beau travail!";
            message[3] = "Continue comme ça!";              
            message[4] = "Non, essaie encore";
            message[5] = "Faux, essaie une autre fois";
            message[6] = "Non, mais il ne faut pas lâcher";
            message[7] = "Non, continue d'essayer";
        }

        public int GetNombreAlea()
        {
            nb1 = rng.Next(0, 13);
            nb2 = rng.Next(0, 13);
            this.resultat = nb1 * nb2;
            return resultat;
        }

        public string AfficherMessage(int reponse)
        {
            if (reponse == this.resultat)
            {
                this.messageShown = message[rng.Next(0, 4)];
                return messageShown;
            }
            else
            {
                this.messageShown = message[rng.Next(4, 8)];
                return messageShown;
            }
        }
        
        

    }
}
