using laba5.Classes.AudioTracks;
using laba5.Classes.Subtitles;

namespace laba5.Classes.MovieFactory
{
    public class GermanMovieFactory : MovieFactory
    {
        public override AudioTrack CreateAudioTrack()
            => new GermanAudioTrack();

        public override Subtitles.Subtitles CreateSubtitles()
            => new GermanSubtitles();
    }
}
