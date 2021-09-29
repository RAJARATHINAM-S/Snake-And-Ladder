using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder_and_Snake_program
{
    class LS2_DICEAdded
    {
        public static void DiceAdded()
        {


           
            Console.WriteLine("welcome to snake and ladder program and start");
            Random random = new Random();
            int diceroll = random.Next(1, 6);
            Console.WriteLine("Player starts the game to move  --->"   + diceroll);

        }



    }
}



      

