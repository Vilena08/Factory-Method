public abstract class Factory
{
    // Фабричный метод — основной метод паттерна.
    // Он абстрактный, поэтому каждая конкретная фабрика должна его реализовать.
    public abstract Product FactoryMethod();
}