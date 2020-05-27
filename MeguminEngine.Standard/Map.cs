using System;
using System.Collections.Generic;
using System.Text;

namespace MeguminEngine.Standard
{
    /// <summary>
	/// 可被战争迷雾影响的单位
	/// </summary>
	public interface IWarFogable
    {
        /// <summary>
        /// 是否在战争迷雾中
        /// </summary>
        int FogState { get; }
    }

    public interface IPositionable<out T>
    {
        /// <summary>
        /// 对象客户端实际世界坐标
        /// </summary>
        T Position { get; }
    }

    public interface ILocationable<out T>
    {
        /// <summary>
        /// 相对坐标/本地坐标/父空间坐标 
        /// </summary>
        T LocalPosition { get; }
    }

}
