class Tamagotchi
{
    private int _fed;
    private int _boredom;
    string _name;
    private List<string> ord = new List<string> { "miau" };

    public Tamagotchi(string name)
    {
        _name = name;
        _boredom = Random.Shared.Next(0,5);
        _fed = Random.Shared.Next(10, 15);
    }

    public void Feed(int amount)
    {
        Console.WriteLine("Omnomnom");
        _fed += amount;
    }
    public void Hi()
    {
        string word = ord[Random.Shared.Next(0, ord.Count())];
        Console.WriteLine(word);

    }
    public void Teach(string word)
    {
        ord.Add(word);
        Console.WriteLine(ord.Count());
    }
    public void Tick()
    {
        _fed -= 1;
        _boredom += 1;
    }
    public void ReduceBoredom()
    {
        Console.WriteLine("Vad KUL det Är Att LEkA mEd DIg :D");
        _boredom -= Random.Shared.Next(1,3);
    }
    public bool GetAlive()
    {
        if (_fed == 0 || _boredom == 10) { return false; }
        else{ return true; }
    }
    public void PrintStats()
    {
        Console.WriteLine("\nmätthet: " + _fed + "\nTråkighet: " + _boredom);
    }
}