Arrow arrow = new Arrow("steel", 60, "plastic");

Console.WriteLine("Choose the arrowhead [steel/wood/obsidian]: ");
arrow._arrowhead = Console.ReadLine();

Console.WriteLine("Choose the shaft [plastic/turkey/goose]: ");
arrow._fletching = Console.ReadLine();

Console.WriteLine("Choose the shaft length [60-100cm]:");
arrow._shaftLength = Convert.ToInt32(Console.ReadLine());

// TODO Remake into enums

Console.WriteLine($"The cost of the arrow is: {arrow.CalculateCost()}");



class Arrow
{
    public string _arrowhead;
    public int _shaftLength;
    public string _fletching;
    
    public Arrow(string arrowhead, int shaftLength, string fletching)
    {
        _arrowhead = arrowhead;
        _shaftLength = shaftLength;
        _fletching = fletching;
    }
    
    // Calculate price TODO Add cases for each material and length
    public decimal CalculateCost()
    {
        decimal cost = 0;

        if (_arrowhead == "steel")
            cost += 10;
        if (_shaftLength == 60)
            cost += _shaftLength * 0.05m;
        if (_fletching == "plastic")
            cost += 10;
        
        return cost;
    }
}