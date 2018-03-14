using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace VOLib.Unity.Service.Unity
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class TimeService : ITimeService
    {
        public float time => Time.time;
        
        public float timeSinceLevelLoad => Time.timeSinceLevelLoad;
        
        public float deltaTime => Time.deltaTime;
        
        public float fixedTime => Time.fixedTime;
        
        public float unscaledTime => Time.unscaledTime;
        
        public float fixedUnscaledTime => Time.fixedUnscaledTime;
        
        public float unscaledDeltaTime => Time.unscaledDeltaTime;
        
        public float fixedUnscaledDeltaTime => Time.fixedUnscaledDeltaTime;

        public float fixedDeltaTime
        {
            get => Time.fixedDeltaTime;
            set => Time.fixedDeltaTime = value;
        }

        public float maximumDeltaTime
        {
            get => Time.maximumDeltaTime;
            set => Time.maximumDeltaTime = value;
        }

        public float smoothDeltaTime => Time.smoothDeltaTime;
        
        public float maximumParticleDeltaTime
        {
            get => Time.maximumParticleDeltaTime;
            set => Time.maximumParticleDeltaTime = value;
        }

        public float timeScale
        {
            get => Time.timeScale;
            set => Time.timeScale = value;
        }

        public int frameCount => Time.frameCount;

        public int renderedFrameCount => Time.renderedFrameCount;
        
        public float realtimeSinceStartup => Time.realtimeSinceStartup;
        
        public int captureFramerate
        {
            get => Time.captureFramerate;
            set => Time.captureFramerate = value;
        }

        public bool inFixedTimeStep => Time.inFixedTimeStep;
    }
}
