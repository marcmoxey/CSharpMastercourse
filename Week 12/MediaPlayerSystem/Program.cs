namespace MediaPlayerSystem;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the Media Player System!");
        System.Console.WriteLine("What would you like to do?");
        System.Console.WriteLine("1. Play Audio File");
        System.Console.WriteLine("2. Play Video File");
        System.Console.WriteLine("3. Play Podcast");
        System.Console.WriteLine("4. Exit");
        System.Console.Write("Please enter your choice (1-4): ");
        IPlayable playable = null;  
        string choice = Console.ReadLine();

        switch(choice) {
            case "1":
                playable = new AudioFile();
                playable.Play();
                playable.Pause();
                playable.Stop();
                break;
            case "2":
                playable = new VideoFile();
                playable.Play();
                playable.Pause();
                playable.Stop();
                break;
            case "3":
                playable = new Podcast();
                playable.Play();
                playable.Pause();
                playable.Stop();
                break;
        }

        Console.ReadLine(); 
    }

    public interface IPlayable {
        void Play();
        void Pause();
        void Stop();
    }

    public class AudioFile : IPlayable
    {
        public void Pause()
        {
           System.Console.WriteLine("Audio file paused.");
        }

        public void Play()
        {
            System.Console.WriteLine("Audio file playing.");
        }

        public void Stop()
        {
            System.Console.WriteLine("Audio file stopped.");
        }
    }

    public class VideoFile : IPlayable
    {
        public void Pause()
        {
            System.Console.WriteLine("Video file paused.");
        }

        public void Play()
        {
           System.Console.WriteLine("Video file playing.");
        }

        public void Stop()
        {
            System.Console.WriteLine("Video file stopped.");
        }
    }

    public class Podcast : IPlayable
    {
        public void Pause()
        {
            System.Console.WriteLine("Podcast paused.");
        }

        public void Play()
        {
            System.Console.WriteLine("Podcast playing.");
        }

        public void Stop()
        {
            System.Console.WriteLine("Podcast stopped.");
        }
    }
}
