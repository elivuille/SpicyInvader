/* ETML
 * Auteur: Jérémie Bussy
 * Date: 07.02.2020
 * Description: programme qui affiche l'ennemi, le fait se déplacer
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy n = new Enemy(); //Création d'un ennemi

            while (true) //Boucle qui va s'executer à l'infini
            {
                Console.CursorVisible = false; //Masque le curseur
                n.Move(); //Appel de la méthode Move
                System.Threading.Thread.Sleep(500); //S'occupe de séquencer le décalage de l'ennemi
            }
        }
    }
}
