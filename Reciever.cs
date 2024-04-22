using System;
using System.IO;
using System.IO.Pipes;

class PipeReciever
{
    static void Main(string[] message)
    {
        using var client = new NamedPipeClientStream ("BigPipe");
        client.Connect();

        using var reader = new StreamReader(client);
        Console.WriteLine(reader.ReadLine());
    }
}