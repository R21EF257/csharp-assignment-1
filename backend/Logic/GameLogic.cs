using backend.Models;
using System;

namespace backend.Logic
{
    public class GameLogic
    {
        private readonly Random _random = new Random();

        public GameResult Play(Move playerMove)
        {
            var computerMove = (Move)_random.Next(3);
            string result;

            switch (computerMove)
            {
                case Move.Rock:
                    result = playerMove switch
                    {
                        Move.Rock => "Draw",
                        Move.Paper => "Player Wins",
                        Move.Scissors => "Computer Wins",
                        _ => "Invalid Move"
                    };
                    break;
                case Move.Paper:
                    result = playerMove switch
                    {
                        Move.Paper => "Draw",
                        Move.Rock => "Computer Wins",
                        Move.Scissors => "Player Wins",
                        _ => "Invalid Move"
                    };
                    break;
                case Move.Scissors:
                    result = playerMove switch
                    {
                        Move.Scissors => "Draw",
                        Move.Rock => "Player Wins",
                        Move.Paper => "Computer Wins",
                        _ => "Invalid Move"
                    };
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return new GameResult
            {
                PlayerMove = playerMove,
                ComputerMove = computerMove,
                Result = result
            };
        }
    }
}
