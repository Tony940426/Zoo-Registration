using  Zoo_Registration;

Console.WriteLine("Zoo Registration");

List<Bird> birds = new List<Bird>();
List<Mammal> mammals = new List<Mammal>();

mammals.Add( new Mammal("Simba", 5, "Golden", true));
mammals.Add( new Mammal("Nala", 4, "Brown", true));

birds.Add(new Bird("Tweety", 2, 0.5, true));
birds.Add(new Bird("Polly", 3, 0.8, false));

Console.WriteLine("\nMAMMALS:");
foreach (var mammal in mammals)
{
    mammal.DisplayDetails();
    Console.WriteLine();
}

Console.WriteLine("\nBIRDS:");
foreach (var bird in birds)
{
    bird.DisplayDetails();
    Console.WriteLine();
}

Console.WriteLine($"Total Animals Registered: {birds.Count + mammals.Count}");
Console.ReadKey();