using laba5.Classes.AudioTracks;
using laba5.Classes.CertainMovieFactory;
using laba5.Classes.CertainSubtitles;

namespace laba5.Classes.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public AudioTrack Audio { get; set; }
        public Subtitles Subs { get; set; }

        public Movie(string title, MovieFactory factory)
        {
            Title = title;
            Audio = factory.CreateAudioTrack();
            Subs = factory.CreateSubtitles();
        }

        public string GetFullInfo()
            => $"Фильм: {Title}\r\n{Audio.GetInfo()}\r\n{Subs.GetInfo()}";
    }
}
