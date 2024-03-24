using tpmodul6_1302220048;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Reihan_Ramadhana_Anwari]");
        video.IncreasePlayCount(0);
        video.PrintVideoDetails();

        Console.WriteLine(" ");

        SayaTubeVideo Video = new SayaTubeVideo("Tutorial Design By Contract - [Reihan_Ramadhana_Anwari]");
        Video.IncreasePlayCount(10000009);
        for (int i = 0; i <= 10; i++)
        {
            Video.IncreasePlayCount(10000009);
        }
        Video.PrintVideoDetails();
    }


}

