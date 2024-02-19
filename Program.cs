﻿using Entities;

HashSet<LogRecord> set = new HashSet<LogRecord>();
Console.Write("Enter file full path: ");
string path = Console.ReadLine();
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord { Username = name, Instant = instant});
        }
        System.Console.WriteLine("\nTotal users: "+set.Count);
    }
}
catch(IOException e)
{
    System.Console.WriteLine(e.Message);
}