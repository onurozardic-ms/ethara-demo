// See https://aka.ms/new-console-template for more information
using CrossPlatformConsoleApplication;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
HelloWorld helloWorld = new HelloWorld();
helloWorld.callHelloInPrivate();
helloWorld.HelloFromPublic();
Console.WriteLine( helloWorld.sum(3,5));
