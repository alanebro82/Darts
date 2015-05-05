namespace Darts.Game
{
    public enum DartMultiplier
    {
        eNone = 1,
        eDouble = 2,
        eTriple = 3,
    }

    public enum DartValue
    {
        eMiss = 0,
        e1 = 1,
        e2 = 2,
        e3 = 3,
        e4 = 4,
        e5 = 5,
        e6 = 6,
        e7 = 7,
        e8 = 8,
        e9 = 9,
        e10 = 10,
        e11 = 11,
        e12 = 12,
        e13 = 13,
        e14 = 14,
        e15 = 15,
        e16 = 16,
        e17 = 17,
        e18 = 18,
        e19 = 19,
        e20 = 20,
        eBull = 25
    }

    public class Dart
    {
        public
        Dart( Player aPlayer, DartValue aValue, DartMultiplier aMultiplier = DartMultiplier.eNone )
        {
            if( aPlayer == null )
            {
                throw new System.ArgumentNullException( paramName: nameof( aPlayer ) );
            }

            ThrownBy = aPlayer;
            Value = aValue;
            Multiplier = aMultiplier;
        }

        /// <summary>
        /// Player who threw the dart
        /// </summary>
        public Player ThrownBy{ get; }

        /// <summary>
        /// Wedge of board hit by player
        /// </summary>
        public DartValue Value{ get; }

        /// <summary>
        /// Multiplier hit by player
        /// </summary>
        public DartMultiplier Multiplier{ get; }

        /// <summary>
        /// Total points dart is worth
        /// </summary>
        public int Points => (int)Value * (int)Multiplier;
    }
}