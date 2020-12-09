using System; 

namespace Dames {
    class Partie{
        private int initialiser = 0;
        public void partie(){
        }
        public void LaPartie(int init){
            this.initialiser = init;
        }

        public int init{ 
            get { return this.initialiser;} 
            set { this.initialiser = value;}
        }
        
        public bool Initialiser(){
            return (this.initialiser == 1) ? true : false;
        }
        public String Ready(){
            return this.Start("Êtes vous prêt à démarrer une partie ? (oui/non)");
        }
        public String Start(String text){
            Console.Write(text);
            String rep = Console.ReadLine();
            try {
                if(rep == "oui"){
                    this.initialiser = 1;
                    //Console.Write(Initialiser());
                    Plateau damier = new Plateau();
                    Console.WriteLine("Commencer une partie ! ");
                    damier.Damier();
                }        
                return rep;
            }
            catch(FormatException){
                return Start(text);
            }
        }

        
    }
}