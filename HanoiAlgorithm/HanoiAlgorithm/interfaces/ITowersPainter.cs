using System;
namespace HanoiAlgorithm
{
    interface ITowersPainter
    {
        static int Up { get; }
        static int Down { get; }
        static int BreakTime { get; }
        static int JumpBetweenElements { get; }
        static ConsoleColor[] ColorsPallete { get; }
               
        static void CreateTowerElement() => throw new NotImplementedException();
        static void StartProgramInConsole() => throw new NotImplementedException();
        static void AnimateMovement() => throw new NotImplementedException();
        static void CleanElement() => throw new NotImplementedException();
        static void FinishVisualization() => throw new NotImplementedException();
        static void StopProgram() => throw new NotImplementedException();       
        static void ManageConsole() => throw new NotImplementedException();
    }
}

