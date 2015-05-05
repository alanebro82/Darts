using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts.Game
{
    class CricketGame : IPlay
    {
        private
        CricketGame( params Player[] aPlayers )
        {
        }

        public void AddDart( Dart aDart )
        {
            if( aDart == null )
            {
                throw new ArgumentNullException( paramName: nameof( aDart ) );
            }

            // TODO: do stuff

            mDarts.Push( aDart );
        }

        public void NewGame( params Player[] aPlayers )
        {
            throw new NotImplementedException();
        }

        public void UndoLast()
        {
            var theLastdart = mDarts.Pop();

            // TODO: undo stuff
        }

        private Stack<Dart> mDarts = new Stack<Dart>();
    }
}
