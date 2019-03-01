using System;
using System.Collections.Generic;
using System.Text;

namespace MeguminEngine.Interface
{
    public static class MeguminEngineInterfaceExtension
    {
        public static float GetLeftSeconds(this ICountdown countdown)
        {
            return (float)(countdown.TotalTime - ((DateTime.Now - countdown.StartTime) ?? TimeSpan.Zero)).TotalSeconds;
        }
    }
}
