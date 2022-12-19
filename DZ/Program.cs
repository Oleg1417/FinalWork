string[] Array = { "hello", "2", ":-)", "g" };
NewArray(Array);

string[] NewArray(string[] Array)
{
    string[] answer = new string[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            answer[i] = Array[i];
        }
    }
    Console.Write("[");
    Console.Write(string.Join(" ", answer));
    Console.Write("]");
    return answer;
}