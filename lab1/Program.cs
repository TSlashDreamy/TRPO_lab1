using lab1;

QuadCollection quadCollection = new QuadCollection();

void WaitForInput()
{
    Console.WriteLine("Select operation:\n1. Add to collection\n2. Remove from collection\n3. Count objects\n4. Show all objects in collection");
    string userOperationNum = Console.ReadLine();
    Console.Clear();

    switch (userOperationNum)
    {
        case "1":
            AddSomeQuadrilateral();
            return;
        case "2":
            Quadrilateral removedQuad = quadCollection.RemoveQuadrilateral();
            if (removedQuad != null)
            {
                Console.WriteLine("Quadrilateral was removed: " + removedQuad.Name);
            }
            break;
        case "3":
            Console.WriteLine("Amount of Quadrilateral in collection: " + quadCollection.Count);
            break;
        case "4":
            quadCollection.ShowQuadliterals();
            break;
        default:
            Console.WriteLine("Invalid operation!");
            break;
    }
    WaitForInput();
}

void AddSomeQuadrilateral()
{
    Console.WriteLine("What you want to add?\n1. Rhombus\n2. Square\n3. Rectangle\n4. Parallelogram");
    string userOperationNum = Console.ReadLine();
    Console.Write("Give a name for your quadliteral: ");
    string figureName = Console.ReadLine();
    Console.Clear();

    switch (userOperationNum)
    {
        case "1":
            quadCollection.AddQuadrilateral(new Rhombus(figureName));
            break;
        case "2":
            quadCollection.AddQuadrilateral(new Square(figureName));
            break;
        case "3":
            quadCollection.AddQuadrilateral(new Rectangle(figureName));
            break;
        case "4":
            quadCollection.AddQuadrilateral(new Parallelogram(figureName));
            break;
        default:
            Console.WriteLine("Invalid type!");
            AddSomeQuadrilateral();
            return;
    }
    WaitForInput();
}

WaitForInput();
