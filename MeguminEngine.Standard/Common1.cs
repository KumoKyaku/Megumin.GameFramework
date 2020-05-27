/*
 * 只有Get,接口中无需Set。
 * 
 */

namespace MeguminEngine.Standard
{
    /// <summary>
    /// 最小约束，用于特定参数传递
    /// </summary>
    public interface IMeguminObject
    {

    }

    public interface IIconID
    {
        int IconID { get; }
    }

    public interface ILabel
    {
        string Label { get; }
    }

    public interface IName
    {
        string Name { get; }
    }

    public interface ITags<in K, V>
    {
        V this[K key] { get; }
    }

    public interface ILabels<in K, V>
    {
        V this[K key] { get; }
    }

    public interface INew
    {
        int IsNew { get; }
    }

    public interface IFavorite
    {
        int? FavoritesTag { get; }
    }

    /// <summary>
    /// 可选择的
    /// </summary>
    public interface ISelectable
    {
        int IsSelected { get; }
    }

    /// <summary>
    /// 可堆叠的
    /// </summary>
    public interface IStackable
    {
        int StackCount { get; }
    }

    public interface ICountable
    {
        int Count { get; }
    }

    /// <summary>
    /// 可拆分的
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISplitable<T>
    {
        (T origibal, T newIntstance) Split(T origibal,int newIntstanceCount);
    }

    /// <summary>
    /// Area Of Interest
    /// </summary>
    public interface IAOIable
    {
        /// <summary>
        /// 是不是感兴趣的 可以监听服务器信息，通常为迷雾外延一格
        /// </summary>
        bool Interesting { get; }
    }

    public interface IConfigID<out T>
    {
        /// <summary>
        /// Gets the config id.
        /// </summary>
        T CfgID { get; }
    }

    public interface IFeatureable
    {
        int Feature { get; }
    }

    /// <summary>
    /// 可完成的
    /// </summary>
    public interface IDoneable
    {
        /// <summary>
        /// 1：成功完成；-1：失败完成；2：取消完成；0： 未完成
        /// </summary>
        int IsDone { get; set; }
    }

    /// <summary>
    /// 可被写入的/可被修改的
    /// </summary>
    public interface IWriteable
    {
        /// <summary>
        /// 0：不可写入； 1： 可以写入
        /// </summary>
        int CanWrite { get; }
    }

    /// <summary>
    /// 可为起始点的
    /// </summary>
    public interface IStartPointable
    {
        /// <summary>
        /// 1: 是起始点
        /// </summary>
        int StartPointState { get; }
    }

    /// <summary>
    /// 关联的资源
    /// </summary>
    public interface IBindAsset
    {
        int AssetID { get; }
    }

    /// <summary>
    /// 可被加载的
    /// </summary>
    public interface ILoadable
    {
        /// <summary>
        /// 0:未开始
        /// </summary>
        int LoadState { get; }
    }
}











