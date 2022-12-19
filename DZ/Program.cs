string[] Array = { "hello", "2", ":-)", "g", "smile" };
int count = 0;

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        count = count + 1;
    }
}

string[] NewArray(string[] Array, int count)
{
    int x = 0;
    string[] answer = new string[count];
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
NewArray(Array, count);