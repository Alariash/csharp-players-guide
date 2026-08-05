void CountdownFrom(int x)
{
    Console.WriteLine(x);
    if (x == 1)
        return;
        
    CountdownFrom(x-1);
}

// It's the Final Countdown!
CountdownFrom(10);