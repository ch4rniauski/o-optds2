using laba5.Classes.AudioTracks;

namespace laba5.Classes.MovieFactory
{
    public abstract class MovieFactory
    {
        public abstract AudioTrack CreateAudioTrack();

        public abstract Subtitles.Subtitles CreateSubtitles();
    }
}
