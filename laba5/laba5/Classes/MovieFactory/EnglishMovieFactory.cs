using laba5.Classes.AudioTracks;
using laba5.Classes.Subtitles;

namespace laba5.Classes.MovieFactory
{
    public class EnglishMovieFactory : MovieFactory
    {
        public override AudioTrack CreateAudioTrack()
            => new EnglishAudioTrack();

        public override Subtitles.Subtitles CreateSubtitles()
            => new EnglishSubtitles();
    }
}
