using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvasionDeLespace
{
    class Enemies
    {
        public void Maingame()
        {
            int tics = 0;
            int x = 3;
            int y = 1;
            char[,] aliens = new char[3, 6];

           
                for (int i = 0; i < 3; i++)
                {
                   
                    Console.SetCursorPosition(x, y);
                    for (int j = 0; j < 6; j++)
                    {
                        aliens[i, j] = 'A';
                        Debug.WriteLine("Column : " + i + " Row : " + j + " Data " + aliens[i, j]);
                        x += 2;
                    Console.SetCursorPosition(x, y);
                    Console.Write(aliens[i, j]);
                       

                    }
                x = 3;
                    y+=3;
                }
               
            

                
                
            
            

            

           
            


        }

        
    }
}
