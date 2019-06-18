using System;
using System.Collections.Generic;

namespace ProjectNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 숫자 카드 입력시 띄어쓰기로 구분해주세요.
            // A팀의 숫자 카드들을 입력해주세요
            Console.WriteLine("숫자 카드 입력시 띄어쓰기로 구분해주세요.");
            Console.Write("A팀의 숫자 카드들을 입력해주세요: ");
            var yourdeck = Console.ReadLine();

            // B팀의 숫자 카드를 입력해주세요
            Console.Write("B팀의 숫자 카드들을 입력해주세요: ");
            var mydeck = Console.ReadLine();

            CardDeck deck = new CardDeck(yourdeck, mydeck);

            CompareDecks compare = new CompareDecks();
            compare.CalculateVictoryPoint(deck.YourDeck, deck.MyDeck);
        }
    }
}

