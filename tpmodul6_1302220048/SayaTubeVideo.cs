namespace tpmodul6_1302220048
{
    internal class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            id = generateRandomid();
            this.playCount = 0;

        }

        private int generateRandomid()
        {
            Random random = new Random();
            return random.Next(00000, 99999);
        }
        public void IncreasePlayCount (int newPlayCount)
        {
            playCount += newPlayCount;

        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);


        }
    }
}
