namespace IoC.Decorator.Example
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    class Program
    {
        static void Main(string[] args)
        {
            var foo = IocProvider.ServiceProvider.GetService<IFoo>();
            foo.PrintHelloWorld();
        }
    }
}