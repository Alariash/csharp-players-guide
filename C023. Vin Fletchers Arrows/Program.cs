Arrow arrow = new Arrow("steel", 60, "plastic");
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
    
    // Calculate price
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