using System.Globalization;
using AdamAsmaca;

string soru = Helper.AskQuestion();
string answer = Helper.AskQuestionAnswer(soru).ToUpper();
int userfalse =8;
List<char> dogruTahminler = new List<char>();
while (userfalse >= 3)
{
    Console.Clear();
    Console.WriteLine("Kalan hak: " + (userfalse-3));
    Helper.man(userfalse);
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine(soru);
    string scwords = "";
    foreach (char c in answer)
    {
        if (c == ' ')
            scwords += " ";
        else if (dogruTahminler.Contains(c))
            scwords += c;
        else
            scwords += "_";
    }
    Console.WriteLine("Cevap: " + scwords);
    
    if (!scwords.Contains("_"))
    {
        Console.WriteLine("Tebrikler! Doğru bildiniz!");
        break;
    }

    Console.Write("Bir harf tahmin et: ");
    char tahmin = Console.ReadLine().ToUpper()[0];

    if (answer.Contains(tahmin))
    {
        dogruTahminler.Add(tahmin);
        Console.WriteLine("Doğru tahmin!");
        Thread.Sleep(1000);
    }
    else
    {
        userfalse--; 
        Console.WriteLine("Yanlış tahmin!");
        Thread.Sleep(1000);
    }


}

if (userfalse == 3)
{
    Console.WriteLine("Oyunu kaybettin! Doğru cevap: " + answer);
}


    
    
   

    



    



