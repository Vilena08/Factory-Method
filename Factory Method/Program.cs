using System;

internal class Program {
  private static void Main(string[] args) {
        FactoryA factoryA = new FactoryA();
        FactoryB factoryB = new FactoryB();

        Factory[] factories = { factoryA, factoryB };

        foreach (Factory factory in factories) {
            Product product = factory.FactoryMethod();
            Console.WriteLine($"Object: {product.GetName()}");
        }

        Console.ReadKey();
    }
}
//В паттерне Factory Method интерфейс Product определяет общий контракт для всех создаваемых объектов. 
//Абстрактный класс Factory содержит фабричный метод FactoryMethod(), который возвращает Product. 
//Каждая конкретная фабрика (FactoryA, FactoryB) переопределяет этот метод и возвращает свой конкретный продукт (ProductA, ProductB). 
//Клиентский код работает с абстракциями и не зависит от конкретных классов продуктов.
