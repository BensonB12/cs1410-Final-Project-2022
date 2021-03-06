namespace Winston
{
    public static class StaticPileOfCards
    {
        private static int player = 1;
        public static int Player
        {
            get
            {
                return player;
            }
            set
            {
                player = value;
            }
        }
        public static bool Using { get; set; }
        public static List<CardModel> PileOfCards { get; set; }
        public static (List<CardModel>, List<CardModel>) PopUpCards = (new List<CardModel>(), new List<CardModel>());
        public static bool BoolPopUpCards = false;
        public static int chosenPlayer = 1;
        public static bool otherPlayerCanSee = false;
        public static bool onlyOnePlayer = true;
        public static List<CardModel> Player1Cards = new List<CardModel>();
        public static List<CardModel> Player2Cards = new List<CardModel>();
        public static bool GameOver = false;
    }
}