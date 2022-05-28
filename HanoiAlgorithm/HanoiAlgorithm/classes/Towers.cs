using System;
using System.Collections.Generic;

namespace HanoiAlgorithm
{    
    public enum HanoiStack
    {
        FirstStack,
        SecondStack,
        ThirdStack,
    }

    class Towers : TowerService, ITowers
    {
        private int _elements;
        private Stack<int>[] _towers;
        private char _stop;
        private string[] _towerElement;

        public int Elements { get => _elements; set => _elements = value; }
        public Stack<int>[] HanoiTowers { get => _towers; set => _towers = value; }
        public char Stop { get => _stop; set => _stop = value; }
        public string[] TowerElement { get => _towerElement; set => _towerElement = value; }

        public Towers(int elements, Stack<int>[] towers, char stop, string[] towerElement)
        {
            _elements = elements;
            _towers = towers;
            _stop = stop;
            _towerElement = towerElement;
        }

        public void HanoiTowersManagement()
        {
            ManageConsole(_elements, _stop);
            StartProgramInConsole(_towerElement, _elements, _towers);

            Console.CursorVisible = false;

            // InitializeStartElements(_elements, _towers[0]);
            HandleHanoiMovement(_elements, 0, 1, 2, _towers, _towerElement, _stop);

            CleanElement(18);
            Console.CursorVisible = true;
        }
    }
}
