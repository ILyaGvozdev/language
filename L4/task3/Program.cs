string GetLettersFromStr(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e) ==true)
        {
            letters += e;
        }
    }
    return letters;    
}

string str = System.Console.ReadLine();
string letters = GetLettersFromStr(str);
System.Console.WriteLine(letters);

// В ней требуется считать строку из букв и цифр, как и в решенной ранее
// задаче. Далее необходимо выбрать из этой строки цифры и сформировать из них
// массив.
