using laba5.Classes.AudioTracks;
using laba5.Classes.Subtitles;

namespace laba5.Classes.MovieFactory
{
    public class RussianMovieFactory : MovieFactory
    {
        public override AudioTrack CreateAudioTrack()
            => new RussianAudioTrack();

        public override Subtitles.Subtitles CreateSubtitles()
            => new RussianSubtitles();
    }
}
