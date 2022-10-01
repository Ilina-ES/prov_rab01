void Massiv()
{
    Console.WriteLine("Введите любые наборы символов через пробел: ");
    string[] text = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);  
    string[] result = new string[text.Length];

    for (int i = 0; i < text.Length; i++)
    {
        string str = text[i];
        if (str.Length <= 3) 
        {
            result[i] = text[i];
        }
    }
    Console.Write($"[{String.Join(" ", result)}]");
}
Massiv();
