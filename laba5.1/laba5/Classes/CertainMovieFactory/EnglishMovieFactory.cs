using laba5.Classes.AudioTracks;
using laba5.Classes.CertainSubtitles;

namespace laba5.Classes.CertainMovieFactory
{
    public class EnglishMovieFactory : MovieFactory
    {
        public override AudioTrack CreateAudioTrack()
            => new EnglishAudioTrack();

        public override Subtitles CreateSubtitles()
            => new EnglishSubtitles();
    }
}
