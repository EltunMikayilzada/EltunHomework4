using System;

var from = 3;
var to = 12;

for (var i = from; i < to; i++)
{
    var symbol = true;
    for (var j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            symbol = false;
            break;
        }
    }
    if (symbol == true && i != 1)
        Console.WriteLine(i);
}
