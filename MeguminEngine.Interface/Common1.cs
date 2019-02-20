namespace MeguminEngine.Interface
{
    public interface IIconID
    {
        int IconID { get; set; }
    }

    public interface ILabel
    {
        string Label { get; set; }
    }

    public interface IName
    {
        string Name { get; set; }
    }

    public interface ITags<in K, V>
    {
        V this[K key] { get; set; }
    }

    public interface ILabels<in K, V>
    {
        V this[K key] { get; set; }
    }
}
