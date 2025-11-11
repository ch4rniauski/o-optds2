using laba5.Classes.AudioTracks;
using laba5.Classes.CertainSubtitles;

namespace laba5.Classes.CertainMovieFactory
{
    public abstract class MovieFactory
    {
        public abstract AudioTrack CreateAudioTrack();

        public abstract Subtitles CreateSubtitles();
    }
}
