namespace MvcLabManager.Models;

public class Lab
{
    public int Id { get; set; }
    public int Num { get; set; }
    public string Name { get; set; }
    public string Block { get; set; }

    public Lab() { }

    public Lab(int id, int num, string name, string block)
    {
        Id = id;
        Num = num;
        Name = name;
        Block = block;
    }
}