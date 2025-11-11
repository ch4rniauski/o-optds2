using laba5.Classes.AudioTracks;
using laba5.Classes.CertainSubtitles;

namespace laba5.Classes.CertainMovieFactory
{
    public class RussianMovieFactory : MovieFactory
    {
        public override AudioTrack CreateAudioTrack()
            => new RussianAudioTrack();

        public override Subtitles CreateSubtitles()
            => new RussianSubtitles();
    }
}
