using System;
using Akka.Actor;

public class HelloActor : UntypedActor
{
    protected override void OnReceive(object message)
    {
        switch (message) {
            case "hello": 
                Console.WriteLine("hello world!");
                break;
            default:
                Console.WriteLine("Unknown command");
                break;
        }
    }
}