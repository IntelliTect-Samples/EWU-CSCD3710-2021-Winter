using System;

namespace CanHazFunny
{
    public class Jester
    {
        private IJokeService? jokeService;
        public IJokeService JokeService
        {
            get { return jokeService!; }
            set { jokeService = value ?? throw new ArgumentNullException(); }
        }

        private IOutputWriter? outputWriter;
        public IOutputWriter OutputWriter
        {
            get { return outputWriter!; }
            set { outputWriter = value ?? throw new ArgumentNullException(); }
        }

        public Jester(IJokeService jokeService, IOutputWriter outputWriter)
        {
            JokeService = jokeService;
            OutputWriter = outputWriter;
        }

        public void TellJoke() => OutputWriter.Write(JokeService.GetJoke());
    }
}
