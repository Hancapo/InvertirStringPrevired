using System.Linq;

string ReverseString(string word)
{
    return new string (word.Reverse().ToArray());
}


Console.WriteLine(ReverseString("Hola Mundo!"));