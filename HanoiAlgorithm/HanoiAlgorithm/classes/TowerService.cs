using System;
using System.Collections.Generic;

namespace HanoiAlgorithm
{
    abstract class TowerService : TowersPainter, ITowerService
    {
        public static void HandleHanoiMovement(int elements, int firstStack, int secondStack, int thirdStack, Stack<int>[] towers, string[] towerElement, char stop)
        {
            if (elements > 1) HandleHanoiMovement(elements - 1, firstStack, thirdStack, secondStack, towers, towerElement, stop);

            MoveElementBetweenStacks(firstStack, thirdStack, towers, towerElement, elements, stop);

            if (elements > 1) HandleHanoiMovement(elements - 1, secondStack, firstStack, thirdStack, towers, towerElement, stop);              
        }

        public static void MoveElementBetweenStacks(int startStack, int finalStack, Stack<int>[] towers, string[] towerElement, int elements, char stop)
        {
            int movingElement = towers[startStack].Pop();

            AnimateMovement(towerElement, startStack, finalStack, towers, movingElement);

            towers[finalStack].Push(movingElement);

            if (towers[2].Count < elements) StopProgram(stop.Equals('T'));
        }
    }
}