/* ETML
 * Auteur: Jérémie Bussy
 * Date: 07.02.2020
 * Description: classe des invaders
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enemy
{
    class Enemy
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int _skyWidth; //Où sera stockée la largeur de la console
        private int _intX = 5; //Position X, initiaisée à 5 pour pas que les ennemis touchent le bord de la console
        private int _intY; //Position Y
        private int _ship; //Bateau


        /// <summary>
        /// Propriétés
        /// </summary>
        public int SkyWidth
        {
            get { return _skyWidth; }
            set { _skyWidth = value; }
        }

        public int IntX
        {
            get { return _intX; }
            set { _intX = value; }
        }

        public int IntY
        {
            get { return _intY; }
            set { _intY = value; }
        }

        public int Ship
        {
            get { return _ship; }
            set { _ship = value; }
        }


        /// <summary>
        /// Méthode qui gère le déplacement des ennemis
        /// </summary>
        public void Move()
        {
            _skyWidth = Console.WindowWidth-5; //-5 pour pas que les ennemis touchent le bord de la console (WindowWidth donne la largeur de la console)

            Erase(); //Efface l'ancien ennemi

            if (_intX < _skyWidth)
            {
                _intX++;
            }

            if (_intX == _skyWidth)
            {
                _intY += 1;
                _intX = 5;
            }

            Draw(); //Dessine le nouvel ennemi après calcul de la nouvelle position
        }

        /// <summary>
        /// Méthode qui dessine les ennemis
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(_intX, _intY);
            Console.Write("*");
        }

        /// <summary>
        /// Màthode qui efface les ennemis
        /// </summary>
        public void Erase()
        {
            Console.SetCursorPosition(_intX, _intY);
            Console.Write(" ");
        }
    }
}
