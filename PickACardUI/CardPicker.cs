using System;

namespace PickACardUI
{
    public class CardPicker
    {
        private static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            //if (value == 2) return "2";
            //if (value == 3) return "3";
            //if (value == 4) return "4";
            //if (value == 5) return "5";
            //if (value == 6) return "6";
            //if (value == 7) return "7";
            //if (value == 8) return "8";
            //if (value == 9) return "9";
            //if (value == 10) return "10";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }
    }
}