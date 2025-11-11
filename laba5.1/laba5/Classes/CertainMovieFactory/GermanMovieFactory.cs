using laba5.Classes.AudioTracks;
using laba5.Classes.CertainSubtitles;

namespace laba5.Classes.CertainMovieFactory
{
    public class GermanMovieFactory : MovieFactory
    {
        public override AudioTrack CreateAudioTrack()
            => new GermanAudioTrack();

        public override Subtitles CreateSubtitles()
            => new GermanSubtitles();
    }
}
