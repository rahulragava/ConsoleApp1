namespace ConsoleApp1;

public class GroupedTextInputComparer : IEqualityComparer<IGroupedTextValueEntity>
{
    public bool Equals(IGroupedTextValueEntity? x, IGroupedTextValueEntity? y)
    {
        var a = x as GroupedTextValueEntity;
        var b = y as GroupedTextValueEntity;

        if (ReferenceEquals(a, b)) return true;
        if (ReferenceEquals(a, null)) return false;
        if (ReferenceEquals(b, null)) return false;
        if (a.GetType() != b.GetType()) return false;
        return a.Text == b.Text;
    }

    public int GetHashCode(IGroupedTextValueEntity obj)
    {
        if (obj is GroupedTextValueEntity o)
        {
            return o.Text.GetHashCode();
        }
        return 0;
    }
}

public interface IGroupedTextValueEntity
{
    string Text { get; set; }
}

public class GroupedTextValueEntity : IGroupedTextValueEntity
{
    public string Text { get; set; }
}