using laba5.Classes.AudioTracks;

namespace laba5.Classes.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public AudioTrack Audio { get; set; }
        public Subtitles.Subtitles Subs { get; set; }

        public Movie(string title, MovieFactory.MovieFactory factory)
        {
            Title = title;
            Audio = factory.CreateAudioTrack();
            Subs = factory.CreateSubtitles();
        }

        public string GetFullInfo()
            => $"Фильм: {Title}\r\n{Audio.GetInfo()}\r\n{Subs.GetInfo()}";
    }
}
