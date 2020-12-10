using System; 

namespace Dames {
    class Partie{

        private int initialiser = 0;
        private static Partie instance = null;
        static Plateau plateau = Plateau.getInstance();

        Joueur joueur = new Joueur();

        private void partie(int init){
            this.initialiser = init;
        }
         public static Partie getInstance(){
            if(instance==null){
                instance = new Partie();
            }
            return instance;
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
                    Plateau damier = new Plateau();
                    Console.WriteLine("Commencer une partie ! ");
                    damier.AfficherDamier(this);
                }        
                return rep;
            }
            catch(FormatException){
                return Start(text);
            }
        }

        
    }
}