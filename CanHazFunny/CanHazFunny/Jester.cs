using System;

namespace CanHazFunny
{
    public class Jester
    {
        private IJokeService jokeService;
        private IJokeOutput jokeOutput;

        public IJokeService JokeService { get => jokeService; private set => jokeService = value??throw new ArgumentNullException(); }
        public IJokeOutput JokeOutput { get => jokeOutput; private set => jokeOutput = value??throw new ArgumentNullException(); }

        public Jester(IJokeService jokeService, IJokeOutput jokeOutput)
        {
            if(jokeService == null){throw new ArgumentNullException();}
            else if(jokeOutput == null){throw new ArgumentNullException();}

            this.JokeService = jokeService;
            this.JokeOutput = jokeOutput;
        }

        
        public void TellJoke(){

            string joke = this.JokeService.GetJoke();
            while(joke.Contains("Chuck Norris")){
                joke = this.JokeService.GetJoke();
            }
            
            this.JokeOutput.PrintJoke(joke);
        }

    }
}
