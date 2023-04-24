
using UnityEngine;
using log4net.Appender;
using log4net.Core;

namespace NineD77.Log

{
    public class UnityDebugAppender : AppenderSkeleton
    {
        protected override void Append(LoggingEvent loggingEvent)
        {
            var message = RenderLoggingEvent(loggingEvent);
            if (loggingEvent.Level == Level.Debug || loggingEvent.Level == Level.Info)
                Debug.Log(message);
            else if (loggingEvent.Level == Level.Warn)
                Debug.LogWarning(message);
            else if (loggingEvent.Level == Level.Error)
                Debug.LogError(message);
        }
    }

}