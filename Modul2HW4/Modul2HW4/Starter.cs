public static class Starter
{
    public static void Run()
    {
        Garden garden = new Garden();
        LengthComparer comparer = new LengthComparer();

        foreach (var item in garden.Plants)
        {
            Console.WriteLine($"Name: {item.Name}, Length: {item.Length}, Quantity: {item.Quantity}, Class: {item.Class}, Family: {item.Family}, Genus: {item.Genus}");
        }

        Console.WriteLine();
        Console.WriteLine($"The number of flowers in the garden: {garden.TotalQuantity()} \n");

        Console.WriteLine("Sorting by Length:");

        Array.Sort(garden.Plants, comparer.Compare);

        foreach (var item in garden.Plants)
        {
            Console.WriteLine($"Name: {item.Name}, Length: {item.Length}, Quantity: {item.Quantity}, Class: {item.Class}, Family: {item.Family}, Genus: {item.Genus}");
        }

        Console.WriteLine();

        Console.WriteLine("Enter a length to find:");

        int length = Convert.ToInt32(Console.ReadLine());

        FindElement.SearchElement(garden.Plants, length);
    }
}
