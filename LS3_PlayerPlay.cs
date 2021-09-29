using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder_and_Snake_program
{
    class LS3_PlayerPlay
    {

        public static void check()
        {
            int initial = 0;
            int start = 0;

            const int ladder = 1;

            const int snake = 2;


           
            
                Random random = new Random();
                int diceroll = random.Next(1, 6);
               
                switch (diceroll)
                {
                    case ladder:
                        start = initial + diceroll;
                        Console.WriteLine("Going UP ");

                        break;

                    case snake:
                         start= initial - diceroll;
                        if (start < 0)
                        {
                          initial = 0;
                        } Console.WriteLine("back to snake end   "+initial);
                        break;

                    default:
                        start = diceroll - diceroll;
                        Console.WriteLine("Ready to start" + start);
                     
                        break;
                }


                
            }
        }


    }

   
            


            
        

        
    

