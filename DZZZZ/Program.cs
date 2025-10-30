int count1 = 0;
int x;
int sumd = 0;
for (x = 2; x <= 5; x++)
{
    for (int d = 1; d <= x; d++) 
    {
        if (x % d == 0) 
        {
            count1++;
        
        }
    }
}
//Console.WriteLine(sumd);
Console.WriteLine(count1);