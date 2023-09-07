namespace lab1;

class QuadCollection
{
    private Stack<Quadrilateral> quadStack;

    public QuadCollection()
    {
        quadStack = new Stack<Quadrilateral>();
    }

    // Додавання чотирикутника до колекції
    public void AddQuadrilateral(Quadrilateral quad)
    {
        quadStack.Push(quad);
        Console.WriteLine($"Added {quad.Name} to collection.");
    }

    // Видалення чотирикутника з колекції
    public Quadrilateral RemoveQuadrilateral()
    {
        if (quadStack.Count > 0)
        {
            return quadStack.Pop();
        }
        else
        {
            Console.WriteLine("Collection is empty!");
            return null;
        }
    }

    // Отримання кількості чотирикутників у колекції
    public int Count
    {
        get { return quadStack.Count; }
    }

    public void ShowQuadliterals()
    {
        foreach (var quad in quadStack)
        {
            Console.WriteLine($"{quad.GetType().Name} | {quad.Name}");
        }
    }
}
