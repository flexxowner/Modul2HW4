public static class FindElement
{
    public static void SearchElement(PlantSpecie[] plants, int length)
    {
        for (int i = 0; i < plants.Length; i++)
        {
            if (plants[i].Length == length)
            {
                Console.WriteLine($"Name: {plants[i].Name}, Length: {plants[i].Length}, Quantity: {plants[i].Quantity}, Class: {plants[i].Class}, Family: {plants[i].Family}, Genus: {plants[i].Genus}");
            }
        }
    }
}
