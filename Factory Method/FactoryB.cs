public class FactoryB : Factory
{
    // Фабрика B создаёт продукт B.
    public override Product FactoryMethod()
    {
        return new ProductB();
    }
}