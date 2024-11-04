using System;

interface IPlayable
{
    void Play();
    void Pause();
    void Stop();
}

interface IRecordable
{
    void Record();
}

class MusicTrack : IPlayable, IRecordable
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public TimeSpan Duration { get; set; }

    private bool isPlaying;

    public MusicTrack(string title, string artist, TimeSpan duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        isPlaying = false;
    }

    public void Play()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            Console.WriteLine($"Playing: {Title} by {Artist}");
        }
        else
        {
            Console.WriteLine($"{Title} is already playing.");
        }
    }

    public void Pause()
    {
        if (isPlaying)
        {
            isPlaying = false;
            Console.WriteLine($"Paused: {Title}");
        }
        else
        {
            Console.WriteLine($"{Title} is not playing.");
        }
    }

    public void Stop()
    {
        if (isPlaying)
        {
            isPlaying = false;
            Console.WriteLine($"Stopped: {Title}");
        }
        else
        {
            Console.WriteLine($"{Title} is not playing.");
        }
    }

    public void Record()
    {
        Console.WriteLine($"Recording: {Title} by {Artist}");
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів музичних треків
        MusicTrack track1 = new MusicTrack("Song One", "Artist A", new TimeSpan(0, 3, 45));
        MusicTrack track2 = new MusicTrack("Song Two", "Artist B", new TimeSpan(0, 4, 15));

        // Тестування методів IPlayable
        track1.Play(); 
        track1.Pause(); 
        track1.Play();  
        track1.Stop();  

        Console.WriteLine();

        // Тестування методу IRecordable
        track2.Record(); 
        track2.Play();   
    }
}