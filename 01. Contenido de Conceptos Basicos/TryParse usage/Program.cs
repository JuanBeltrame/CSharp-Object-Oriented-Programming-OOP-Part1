string numString = "a123";
int num;

if(int.TryParse(numString, out num))
{
    Console.WriteLine("Converting Success: " + num);
}
else
{
    Console.WriteLine("Converting failed");
}

bool gotParsed = int.TryParse(numString, out num);