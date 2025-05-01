namespace AdamAsmaca;

public class Helper
{
    public static string AskQuestion()
    {
        
        Random rnd = new Random();
        int sayi = rnd.Next(10);
        string[] sorular = new string[]
        {
            "Bir İl ?",
            "Bir Araba Markası ?",
            "Bir Akademi İsmi ?",
            "Bir Popüler Eğitmen ?",
            "Bir Meyve Adı ?",
            "Bir Mevsim Adı ?",
            "Bir Renk ?",
            "Bir İşletim Sistemi Adı ?",
            "Bir Ülke İsmi ?",
            "Bir Spor Dalı ?"
        };
        if (sayi >= 0 && sayi < sorular.Length)
            return sorular[sayi];
        else
            return "Soru Bulunamadı :(";
        



    }
    public static void man(int userfalse)
    {
        
        Console.WriteLine("   +---+");
        Console.WriteLine("   |   |");
        if (userfalse <= 7)
            Console.WriteLine("   O   |");
        else
            Console.WriteLine("       |");
        if (userfalse <= 5)
            Console.WriteLine("  /|\\  |");
        else if (userfalse == 6)
            Console.WriteLine("  /|   |");
        else
            Console.WriteLine("       |");
        if (userfalse <= 3)
            Console.WriteLine("  / \\  |");
        else if (userfalse == 4)
            Console.WriteLine("  /    |");
        else
            Console.WriteLine("       |");

        Console.WriteLine("       |");
        Console.WriteLine("=========");
        
        
    }

    public static string AskQuestionAnswer(string question)
    {
        if (question == "Bir İl ?")
        {
            return "Denizli";
        }
        if (question == "Bir Araba Markası ?")
        {
            return "Proton";
        }
        if (question == "Bir Akademi İsmi ?")
        {
            return "Acunmedya Akademi";
        }
        if (question == "Bir Popüler Eğitmen ?")
        {
            return "Orhan Ekici";
        }
        if (question == "Bir Meyve Adı ?")
        {
            return "Ejder Meyvesi";
        }
        if (question == "Bir Mevsim Adı ?")
        {
            return "Sonbahar";
        }
        if (question == "Bir Renk ?")
        {
            return "Eflatun";
        }
        if (question == "Bir İşletim Sistemi Adı ?")
        {
            return "Linux";
        }
        if (question == "Bir Ülke İsmi ?")
        {
            return "Portekiz";
        }
        if (question == "Bir Spor Dalı ?")
        {
            return "Futbol";
        }
        else
            return "Bulunamadı :(";
    }
}
