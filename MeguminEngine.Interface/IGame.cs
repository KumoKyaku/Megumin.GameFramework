
namespace MeguminEngine.Interface
{
    /// <summary>
    /// 任务
    /// </summary>
    public interface IQuest
    {

    }

    /// <summary>
    /// 提示
    /// </summary>
    public interface ITip
    {

    }

    /// <summary>
    /// 提示
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITip<out T>:ITip
    {
        T TipValue { get; }
    }

    /// <summary>
    /// 路标/路牌
    /// </summary>
    public interface IGuidepost
    {

    }

    /// <summary>
    /// 订单
    /// </summary>
    public interface IOrderForm
    {

    }

    /// <summary>
    /// 战斗结果
    /// </summary>
    public interface IBattleResult
    {

    }

    /// <summary>
    /// 奖励，报酬
    /// </summary>
    public interface IReward
    {

    }

    /// <summary>
    /// 可被AI驱动的
    /// </summary>
    public interface IAIable
    {

    }

    /// <summary>
    /// 有限状态机
    /// </summary>
    public interface IFSM
    {

    }

    /// <inheritdoc/>
    public interface IFSM<out State>: IFSM
    {

    }

    /// <summary>
    /// 小队/团队/小组/势力 成员
    /// </summary>
    public interface IMember
    {

    }

}
