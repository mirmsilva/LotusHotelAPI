using System;

public class Room
{
    public int Id { get; set; }
    public string Name { get; set; }
    public FloorPlans FloorPlan { get; set; }
}

public enum FloorPlans
{
    0 = "Studio",
    1 = "1 Bedroom",
    2 = "2 Bedroom",
}