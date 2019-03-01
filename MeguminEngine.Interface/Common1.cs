/*
 * 为了减少接口数量，没有将get,set 拆分。
 * 各个实现层注意，如无必要，谨慎使用 set。
 * 
 */

namespace MeguminEngine.Interface
{
    /// <summary>
    /// 最小约束，用于特定参数传递
    /// </summary>
    public interface IMeguminObject
    {

    }

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

    public interface INew
    {
        bool IsNew { get; set; }
    }

    public interface IFavorite
    {
        int? FavoritesTag { get; set; }
    }

    public interface ISelectable
    {
        bool IsSelected { get; }
    }

    public interface IStackable
    {
        int StackCount { get; set; }
    }

    public interface ICount<T> where T : struct
    {
        T Count { get; set; }
    }

    /// <summary>
    /// 可拆分的
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISplitable<T>
    {
        (T origibal, T newIntstance) Split(T origibal,int newIntstanceCount);
    }
}
