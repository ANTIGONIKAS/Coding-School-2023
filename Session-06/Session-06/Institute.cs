using System;

public class Institute
{   // properties
    public Guid ID { get; set }
    public string Name { get; set; }
    public int YearsInService { get; set; }

    public Institute()
    {

    }
    public Institute(Guid id, string name, int yearsInService)
    {
        ID = id;
        Name = name;
        YearsInService = yearsInService;
    }

    public void GetName()
    {
    }
    public void SetName(string name)
    {
    }
}