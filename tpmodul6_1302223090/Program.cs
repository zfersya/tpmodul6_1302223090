// See https://aka.ms/new-console-template for more information

using System;

namespace tpmodul6_1302223090;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title)  )
        {
            Console.WriteLine("Inputan Kosong");
        }
        else
        {
            Random random = new Random();
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }
    }
    public void IncreasePlayCount(int x)
    {
        this.playCount = x;
    }
    public void PrintVideoDetails()
    {
        
        Console.WriteLine("ID       : " + id + "\n");
        Console.WriteLine("Title    : " + title);
        Console.WriteLine("Played   : " + this.playCount + " times \n");
        
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Fersya Zufar]");
        video.IncreasePlayCount(10000000);
        video.PrintVideoDetails();
    }
    

}