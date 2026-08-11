ArrowHead arrowHead;
ArrowFletching arrowFletching;
int shaftLength = 0;

Console.WriteLine("Choose the arrowhead:\n1 - Steel\n2 - Wood\n3 - Obsidian");
Console.Write("> ");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        arrowHead = ArrowHead.Steel;
        break;
    case 2:
        arrowHead = ArrowHead.Wood;
        break;
    case 3:
        arrowHead = ArrowHead.Obsidian;
        break;
    default:
        arrowHead = ArrowHead.Unknown;
        break;
}

Console.WriteLine("Choose the shaft:\n1 - Plastic\n2 - Turkey Feathers\n3 - Goose Feathers");
Console.Write("> ");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        arrowFletching = ArrowFletching.Plastic;
        break;
    case 2:
        arrowFletching = ArrowFletching.TurkeyFeather;
        break;
    case 3:
        arrowFletching = ArrowFletching.GooseFeather;
        break;
    default:
        arrowFletching = ArrowFletching.Unknown;
        break;
}

while (shaftLength < 60 || shaftLength > 100)
{
    Console.WriteLine("Choose the shaft length [60-100cm]");
    Console.Write("> ");
    shaftLength = Convert.ToInt32(Console.ReadLine());
}

// Craft the arrow
Arrow arrow = new Arrow(arrowHead, arrowFletching, shaftLength);

// Calculate the cost
if (arrowHead != ArrowHead.Unknown && arrowFletching != ArrowFletching.Unknown)
    Console.WriteLine($"The cost of that arrow is: {arrow.CalculateCost()}");
else
    Console.WriteLine("Stop wasting my time with weird requests. I do NOT make arrows with recycled dog fur!");


class Arrow
{
    public ArrowHead _arrowhead;
    public ArrowFletching _fletching;
    public int _shaftLength;
    
    public Arrow(ArrowHead arrowhead, ArrowFletching fletching, int shaftLength)
    {
        _arrowhead = arrowhead;
        _shaftLength = shaftLength;
        _fletching = fletching;
    }
    
    public decimal CalculateCost()
    {
        decimal cost = 0;

        // Add the cost of the arrowhead
        if (_arrowhead == ArrowHead.Steel)
            cost += 10;
        else if (_arrowhead == ArrowHead.Wood)
            cost += 3;
        else if (_arrowhead == ArrowHead.Obsidian)
            cost += 5;
        else
            cost += 0;
        
        // Add the cost of the fletching
        if (_fletching == ArrowFletching.Plastic)
            cost += 10;
        if (_fletching == ArrowFletching.TurkeyFeather)
            cost += 5;
        if (_fletching == ArrowFletching.GooseFeather)
            cost += 3;
        
        // Add the cost of shaft by length
        cost += _shaftLength * 0.05m;
        
        return cost;
    }
}

enum ArrowHead {Unknown, Steel, Wood, Obsidian};
enum ArrowFletching {Unknown, Plastic, TurkeyFeather, GooseFeather};