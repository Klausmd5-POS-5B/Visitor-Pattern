namespace ElementLib;

public class ElementA : Element
{
    public override void Accept(IVisitor visitor) => visitor.Visit(this);

    public string OperationA()
    {
        Console.WriteLine("    ElementA: OperationA");
        return $"A_{Name}";
    }
}