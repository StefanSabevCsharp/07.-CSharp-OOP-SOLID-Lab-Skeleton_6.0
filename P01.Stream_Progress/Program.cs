namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {   
            
            StreamProgressInfo streamProgressInfo = new StreamProgressInfo(new Music("Artist", "Album", 100, 50));

            streamProgressInfo.CalculateCurrentPercent();


        }
    }
}
