﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashClone
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(640, 480);
            game.Run(1.0 / 60.0);
        }
    }
}
