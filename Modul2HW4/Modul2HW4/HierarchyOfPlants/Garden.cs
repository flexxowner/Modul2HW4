public class Garden : IGarden
{
    public PlantSpecie[] Plants = new PlantSpecie[5]
    {
            new PlantSpecie() { Name = "Clover", Length = 12, Quantity = 2, Class = "dicotyledons", Family = "legumes", Genus = "Clover" },
            new PlantSpecie() { Name = "Pine tree", Length = 150, Quantity = 5, Class = "Conifers", Family = "Pine ", Genus = "Coniferous plants" },
            new PlantSpecie() { Name = "Clover", Length = 200, Quantity = 3, Class = "dicotyledons", Family = "legumes", Genus = "Clover" },
            new PlantSpecie() { Name = "Pine tree", Length = 300, Quantity = 5, Class = "Conifers", Family = "Pine ", Genus = "Coniferous plants" },
            new PlantSpecie() { Name = "Clover", Length = 300, Quantity = 1, Class = "Conifers", Family = "Pine ", Genus = "Coniferous plants" }
    };

    public int TotalQuantity()
    {
        int totalWeight = 0;
        for (int i = 0; i < Plants.Length; i++)
        {
            totalWeight += Plants[i].Quantity;
        }

        return totalWeight;
    }
}
