using ElementLib;

namespace VisitorLib;

public class VisitorY : IVisitor
{
    private List<string> _names = new();
    public string Result => string.Join(", ", _names);

    public void Visit(ElementA elementA) => _names.Add($"__{elementA.OperationA()}__");
    public void Visit(ElementB elementB) => _names.Add(elementB.Name.ToUpper());

    //public override string OperationY() => $"__{OperationA()}__";
    //public override string OperationY() => Name.ToUpper();

    // var names = new List<string>();
    //     foreach (var item in elements)
    // {
    //     string s = item.OperationY();
    //     names.Add(s);
    // }
    // string result = string.Join(";", names);
    // Console.WriteLine($"OperationY: {result}");
}