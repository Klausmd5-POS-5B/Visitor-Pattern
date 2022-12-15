using ElementLib;

namespace VisitorLib;

public class VisitorX : IVisitor
{
    public  int Value { get; private set; } = 0;
    public void Visit(ElementA elementA)
    {
        int val = elementA.Name.Length / 2;
        Value += val;
    }

    public void Visit(ElementB elementB)
    {
        int val = elementB.OperationB() * 3;
        Value += val;
    }
    
    // public override int OperationX() => Name.Length / 2;
    // public override int OperationX() => OperationB() * 3;
    
    // int value = 0;
    //     foreach (var item in elements)
    // {
    //     int val = item.OperationX();
    //     value += val;
    // }
}