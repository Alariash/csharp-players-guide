Arrowhead arrowHead;
ArrowFletching arrowFletching;
int shaftLength = 0;

Console.WriteLine("Choose the arrowhead:\n1 - Steel\n2 - Wood\n3 - Obsidian");
Console.Write("> ");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        arrowHead = Arrowhead.Steel;
        break;
    case 2:
        arrowHead = Arrowhead.Wood;
        break;
    case 3:
        arrowHead = Arrowhead.Obsidian;
        break;
    default:
        arrowHead = Arrowhead.Unknown;
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
if (arrowHead != Arrowhead.Unknown && arrowFletching != ArrowFletching.Unknown)
    Console.WriteLine($"The cost of that arrow is: {arrow.GetCost()}");
else
    Console.WriteLine("Stop wasting my time with weird requests. I do NOT make arrows with recycled dog fur!");


class Arrow
{
    private Arrowhead Arrowhead { get; }
    private ArrowFletching Fletching { get; }
    private int ShaftLength { get; }

    public Decimal GetCost() => CalculateCost();
    
    public Arrow(Arrowhead arrowhead, ArrowFletching fletching, int shaftLength)
    {
        Arrowhead = arrowhead;
        ShaftLength = shaftLength;
        Fletching = fletching;
    }
    
    public decimal CalculateCost()
    {
        decimal cost = 0;

        // Add the cost of the arrowhead
        if (Arrowhead == Arrowhead.Steel)
            cost += 10;
        else if (Arrowhead == Arrowhead.Wood)
            cost += 3;
        else if (Arrowhead == Arrowhead.Obsidian)
            cost += 5;
        else
            cost += 0; 
        
        // Add the cost of the fletching
        if (Fletching == ArrowFletching.Plastic)
            cost += 10;
        if (Fletching == ArrowFletching.TurkeyFeather)
            cost += 5;
        if (Fletching == ArrowFletching.GooseFeather)
            cost += 3;
        
        // Add the cost of shaft by length
        cost += ShaftLength * 0.05m;
        
        return cost;
    }
}

enum Arrowhead {Unknown, Steel, Wood, Obsidian};
enum ArrowFletching {Unknown, Plastic, TurkeyFeather, GooseFeather};