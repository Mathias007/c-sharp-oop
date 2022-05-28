using System;
using System.Collections.Generic;

namespace HanoiAlgorithm
{
    interface ITowers
    {
        int Elements { get; set; }
        Stack<int>[] HanoiTowers { get; set; }
        char Stop { get; set; }
        string[] TowerElement { get; set; }

        static void HanoiTowersManagement() => throw new NotImplementedException();
    }
}
