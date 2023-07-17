namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private File file;

        // If we want to stream a music file, we can't
        //doesnt work with music
        public StreamProgressInfo(Music file)
        {

            this.file = file;
        }

        public StreamProgressInfo(File file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Length;
        }
    }
}
