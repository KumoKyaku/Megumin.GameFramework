using System;
using System.Collections.Generic;
using System.Text;

namespace MeguminEngine.Interface
{
    public interface ICountdown
    {
        /// <summary>
        /// 空表示倒计时还没有开始
        /// </summary>
        DateTime? StartTime { get; set; }
        TimeSpan TotalTime { get; set; }
    }

    public interface ICountdownEvent
    {
        event Action<ICountdown> OnBegin;
        event Action<ICountdown> OnPause;
        event Action<ICountdown> OnContinue;
        event Action<ICountdown> OnEnd;
    }
}
