// Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.
// Write a function which takes a list of strings and returns each line prepended by the correct number.
// The numbering starts at 1. The format is n: string. Notice the colon and space in between.

// Example:
// number(List<string>()) // => List<string>()
// number(List<string>{"a", "b", "c"}) // => ["1: a", "2: b", "3: c"]

// Linq
public class LineNumbering
{
    public static List<string> Number(List<string> lines) => lines.Select((x,i) => $"{i+1}: {x}").ToList();
}

//Generics
public class LineNumbering
{
    public class List<string> Number(List<string> lines)
    {
        for(int i = 0; i < lines.Count; i++)
        {
            lines[i] = (i+1) + ": " +lines[i];
        }

        return lines;
    }
}