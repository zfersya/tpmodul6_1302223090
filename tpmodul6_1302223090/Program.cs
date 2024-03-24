namespace tpmodul6_1302223090;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        /*int length = title.Length;
        if (string.IsNullOrEmpty(title) && length <= 100)
        {
            Console.WriteLine("Inputan Title Kosong atau melebihi 100 ");
        }
        else
        {
            Random random = new Random();
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }*/
        if (string.IsNullOrEmpty(title) || title.Length > 100)
        {
            throw new ArgumentException("Inputan Title Kosong atau melebihi 100 karakter");
        }
        Random random = new Random();
        this.title = title;
        this.id = random.Next(10000, 99999);
        this.playCount = 0;
    }
    public void IncreasePlayCount(int x)
    {
        if (x > 10000000)
        {
            Console.WriteLine("Too Many Count");
        }
        else
        {
            try
            {
                checked
                {
                  playCount += x;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow" + e);
            }
        }
    }
    public void PrintVideoDetails()
    {
        
        Console.WriteLine("ID       : " + id );
        Console.WriteLine("Title    : " + title);
        Console.WriteLine("Played   : " + this.playCount + " times \n");
        
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Fersya Zufar]");
            video.IncreasePlayCount(69);
            video.PrintVideoDetails();

            for (int i = 0; i < 15; i++)
            {
                video.IncreasePlayCount(10000000);
            }
            video.PrintVideoDetails();

           
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"ArgumentException: {e.Message}");
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"OverflowException: {e.Message}");
        }
        try
        {
            SayaTubeVideo video2 = new SayaTubeVideo("");
            video2.PrintVideoDetails();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"ArgumentException: {e.Message}");
        }
    }
}
