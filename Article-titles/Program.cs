// See https://aka.ms/new-console-template for more information
using Article_titles;

string text = "the CLASH OF clans";
string exceptionWords = "the of";
Console.WriteLine("Начальные данные: " + text +' '+exceptionWords);
Console.WriteLine(ArticleProvider.GetTitle(text.Split(' '), exceptionWords.Split(' ')));
