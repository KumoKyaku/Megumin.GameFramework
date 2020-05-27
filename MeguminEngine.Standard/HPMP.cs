namespace MeguminEngine.Standard
{
    public delegate void OnValueChanged<T>(in T newValue, in T oldValue, object state = null);

    public interface IChangedValue<T> where T : struct
    {
        T Value { get; set; }
        event OnValueChanged<T> OnValueChanged;
    }

    public interface IClampedValue<T> : IChangedValue<T>
         where T : struct
    {
        T? Max { get; set; }
        T? Min { get; set; }
    }

    public interface IGameValue<T> : IClampedValue<T>
        where T : struct
    {
        T? LimitMax { get; set; }
        T? LimitMin { get; set; }
    }

    public interface IHP<T> where T : struct
    {
        IGameValue<T> HP { get; set; }
    }

    public interface IMP<T> where T : struct
    {
        IGameValue<T> MP { get; set; }
    }

    /// <summary>
    /// 体力
    /// </summary>
    public interface IVitality<T> where T : struct
    {
        /// <summary>
        /// 体力
        /// </summary>
        IGameValue<T> Vitality { get; set; }
    }

    /// <summary>
    /// 能量
    /// </summary>
    public interface IEnergy<T> where T : struct
    {
        /// <summary>
        /// 能量
        /// </summary>
        IGameValue<T> Energy { get; set; }
    }

    /// <summary>
    /// 攻击力
    /// </summary>
    public interface IATK<T> where T : struct
    {
        /// <summary>
        /// 攻击力
        /// </summary>
        IGameValue<T> ATK { get; set; }
    }

    public interface IRunSpeed<T> where T : struct
    {
        IGameValue<T> RunSpeed { get; set; }
    }
}
