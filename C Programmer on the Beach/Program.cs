List<int> result = new();
int t = Int32.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = Int32.Parse(Console.ReadLine());
    string[] array = Console.ReadLine().Split(" ").Select(o => Convert.ToString(Int32.Parse(o), 2)).ToArray();
    for (int j = 0; j < array.Length - 1; j++)
    {
        array[j] = array[j].PadLeft(array[^1].Length, '0');
    }
    int min = 0;
    for (int j = 0; j < array.Length; j++)
    {
        for (int k = j + 1; k < array.Length; k++)
        {
            string s = "";
            for (int l = 0; l < array[^1].Length; l++) 
            {
                if (array[j][l] == array[k][l]) s += "0";
                else s += "1";
            }
            if (min > Convert.ToInt32(s, 2) || min == 0) min = Convert.ToInt32(s, 2);
        }
    }
    result.Add(min);
}
foreach (int i in result) { Console.WriteLine(i); }