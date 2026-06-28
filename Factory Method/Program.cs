using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создаём экземпляры конкретных фабрик.
        FactoryA factoryA = new FactoryA();
        FactoryB factoryB = new FactoryB();

        // Помещаем их в массив фабрик (работаем через абстрактный тип Factory).
        Factory[] factories = { factoryA, factoryB };

        // Перебираем фабрики. Для каждой вызываем фабричный метод.
        // Нам не важно, какая именно фабрика — она сама знает, какой продукт создавать.
        foreach (Factory factory in factories)
        {
            Product product = factory.FactoryMethod();
            Console.WriteLine($"Object: {product.GetName()}");
        }

        Console.ReadKey();
    }
}
//В паттерне Factory Method интерфейс Product определяет общий контракт для всех создаваемых объектов. Абстрактный класс Factory содержит фабричный метод FactoryMethod(), который возвращает Product. Каждая конкретная фабрика (FactoryA, FactoryB) переопределяет этот метод и возвращает свой конкретный продукт (ProductA, ProductB). Клиентский код работает с абстракциями и не зависит от конкретных классов продуктов.