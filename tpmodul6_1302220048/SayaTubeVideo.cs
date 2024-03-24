namespace tpmodul6_1302220048
{
    internal class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVideo(string title)
        {
            if (title != null && title.Length < 100)
            {
                this.title = title;
            }
            else
            {
                throw new ArgumentException("TITLE TIDAK BOLEH KOSONG DAN PANJANG KURANG DARI 100 KATA");
            }
           

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
            try
            {
                checked
                {
                    if (newPlayCount >= 0 && newPlayCount <= 10000000)
                    {
                        playCount += newPlayCount;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                Console.WriteLine(ArgumentOutOfRangeException.Message);
            }


        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }


    }
}
