using System;
using Akka.Actor;

namespace AkkaNetHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("HelloActorSystem");
            var actorRef = system.ActorOf(Props.Create<HelloActor>(), "hello-world-actor");

            actorRef.Tell("hello");
            actorRef.Tell("yo");

            system.Terminate();

            Console.WriteLine("Done");
        }
    }
}
