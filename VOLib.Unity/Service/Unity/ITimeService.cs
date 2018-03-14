using System.Diagnostics.CodeAnalysis;

namespace VOLib.Unity.Service.Unity
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public interface ITimeService
    {
        int captureFramerate { get; set; }
        float deltaTime { get; }
        float fixedDeltaTime { get; set; }
        float fixedTime { get; }
        float fixedUnscaledDeltaTime { get; }
        float fixedUnscaledTime { get; }
        int frameCount { get; }
        bool inFixedTimeStep { get; }
        float maximumDeltaTime { get; set; }
        float maximumParticleDeltaTime { get; set; }
        float realtimeSinceStartup { get; }
        int renderedFrameCount { get; }
        float smoothDeltaTime { get; }
        float time { get; }
        float timeScale { get; set; }
        float timeSinceLevelLoad { get; }
        float unscaledDeltaTime { get; }
        float unscaledTime { get; }
    }
}