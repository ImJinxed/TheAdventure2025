using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAdventure.Models
{
    public static class GameManager
    {
        public static bool IsGameOver { get; private set; } = false;

        public static void TriggerGameOver()
        {
            IsGameOver = true;
            // Additional logic (pause game, stop input, etc.)
        }
    }

}
