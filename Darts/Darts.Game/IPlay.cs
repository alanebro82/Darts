using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts.Game
{
    interface IPlay
    {
        /// <summary>
        /// Starts a new game of darts.
        /// </summary>
        /// <param name="aPlayers">list of players playing</param>
        void NewGame( params Player[] aPlayers );

        /// <summary>
        /// Adds a single dart to the game.
        /// </summary>
        /// <param name="aDart">dart thrown</param>
        /// <param name="aPlayer">player to add the dart to</param>
        void AddDart( Dart aDart );

        /// <summary>
        /// Rolls back the game to the previous throw.
        /// </summary>
        void UndoLast();


    }
}
