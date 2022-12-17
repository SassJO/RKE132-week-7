Console.WriteLine("Are you coming or leaving?(in/out)");
string userChoise = Console.ReadLine();

if(userChoise == "in")
{
    PrintHello();

}
else
{
    PrintGoodBye();
}

PrintHello();
PrintGoodBye();

static void PrintHello()
{
    Console.WriteLine("hello world!");
}
static void PrintGoodBye()
{
    Console.WriteLine("see you later");
}



