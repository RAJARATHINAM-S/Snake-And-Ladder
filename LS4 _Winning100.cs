using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder_and_Snake_program
{
    class LS4__Winning100
    {
        public static void check()
        {
            int initial = 0;
            int start = 0;

            const int ladder = 1;
            const int snake = 2;
            
            
                while(initial<100)
                {
                    Random random = new Random();
                    int diceroll = random.Next(1, 6);
                    Console.WriteLine("dice ------------------>" + diceroll);


                    switch (diceroll)
                    {
                        case ladder:
                            initial = initial + diceroll;
                            Console.WriteLine("Going UP ");

                            break;

                        case snake:
                            initial = initial - diceroll;
                            while (initial <= 0)
                            {
                                Console.WriteLine("back to start");
                                initial = initial - initial;

                                break;
                            }

                            break;

                        default:
                            initial = initial + diceroll;
                            break;
                    }

                    initial = initial + start;

                    Console.WriteLine("positin   " + initial);
                }

            }
        }
    }
  

        

        
    

    

