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

            do
            {
                for (int i = 0; i < 3; i++)
                {
                    y += 3;
                    x = 3;
                    Console.SetCursorPosition(x, y);
                    for (int j = 0; j < 6; j++)
                    {
                        aliens[i, j] = 'A';
                        Debug.WriteLine("Column : " + i + " Row : " + j + " Data " + aliens[i, j]);
                        Console.SetCursorPosition(x, y);
                        x += 3;
                        Console.Write(aliens[i, j]);

                    }
                }
                System.Threading.Thread.Sleep(250);
                x += 3;
            } while (x < 40);

                
                
            
            

            

           
            


        }

        
    }
}
