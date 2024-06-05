using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Article_titles
{
    public class ArticleProvider
    {
        public static string GetTitle(string[] titleWords, string[] exceptionWords)
        {
            var textInfo = new CultureInfo("ru-RU").TextInfo;
            titleWords[0] = textInfo.ToTitleCase(textInfo.ToLower(titleWords[0]));
            for (int i = 1; i < titleWords.Length; i++)
            {
                if (exceptionWords.Contains(titleWords[i].ToLower()) == false)
                {
                    titleWords[i] = textInfo.ToTitleCase(textInfo.ToLower(titleWords[i]));
                }
                else
                {
                    titleWords[i] = titleWords[i].ToLower();
                }
            }
            return string.Join(" ", titleWords);
        }
    }
}
