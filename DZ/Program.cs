string[] Array = { "hello", "2", ":-)", "g" };
NewArray(Array);

string[] NewArray(string[] Array)
{
    int x = 0;
    string[] answer = new string[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {

        if (Array[i].Length <= 3)
        {
            answer[x] = Array[i];
            x = x + 1;
        }
    }
    Console.Write("[");
    Console.Write(string.Join(", ", answer));
    Console.Write("]");
    return answer;
}