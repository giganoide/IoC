using System;
using Unity;
using SimpleInjector;

namespace RunnerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unity");
            var unityContainer = new UnityContainerTest();
            unityContainer.Init();
            var user = unityContainer.Run();
            Console.WriteLine(user.GetUserName(1));
            Console.ReadKey();

            Console.WriteLine("SimpleInjector");
            var simpleInjectorContainer = new SimpleInjectorTest();
            simpleInjectorContainer.Init();
            user = simpleInjectorContainer.Run();
            Console.WriteLine(user.GetUserName(2));
            Console.ReadKey();
        }
    }
}
