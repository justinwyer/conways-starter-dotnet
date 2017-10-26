using System;
using System.IO;
using System.Linq;

namespace Conways
{
    public class TextWriterGameOutput
    {
        private readonly int _worldSize;
        private readonly TextWriter _outputStream;

        public TextWriterGameOutput(int worldSize, TextWriter outputStream)
        {
            _worldSize = worldSize;
            _outputStream = outputStream;
        }
        public void Display(Boolean[][] gameState)
        {
            var output = string.Join("\n", gameState.Select(s => string.Join("", s.Select(c => c ? "█" : "░"))));
            _outputStream.Write("\n" + output);
        }
    }
}