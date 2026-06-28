public class FactoryA : Factory
{
    // Фабрика A создаёт продукт A.
    public override Product FactoryMethod()
    {
        return new ProductA();
    }
}