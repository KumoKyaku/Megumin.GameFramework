namespace MeguminEngine.Interface
{
    /// <summary>
    /// 当移动停止时回调，可能时卡住或到达目的地
    /// </summary>
    /// <param name="currentPostion"></param>
    /// <param name="destination"></param>
    public delegate void OnMoveStop((double x, double y, double z) currentPostion, (double x, double y, double z) destination);

    /// <summary>
    /// 对象可移动的接口
    /// </summary>
    public interface IMovement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="destination"></param>
        void MoveTo((double x, double y, double z) destination);
        /// <summary>
        /// 当移动停止时回调，可能时卡住或到达目的地
        /// </summary>
        event OnMoveStop OnMoveEnd;
    }
}
