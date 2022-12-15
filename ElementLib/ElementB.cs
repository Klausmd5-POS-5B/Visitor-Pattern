namespace ElementLib;

public class ElementB : Element
{
    public override void Accept(IVisitor visitor) => visitor.Visit(this);
    
    public int OperationB()
    {
        Console.WriteLine("    ElementB: OperationB");
        return Random.Shared.Next(10); // stod am neichn random generator
    }
}