using JetBrains.Annotations;
using UnityTime = UnityEngine.Time;

namespace FK.Common
{
    /// <summary>
    /// Provides an interface to get game-clock time information from Unity.
    /// </summary>
    [PublicAPI]
    public static class GameTime
    {
        /// <inheritdoc cref="UnityTime.frameCount"/>
        public static int FrameCount => UnityTime.frameCount;

        /// <inheritdoc cref="UnityTime.deltaTime"/>
        public static float Delta => UnityTime.deltaTime;

        /// <inheritdoc cref="UnityTime.fixedDeltaTime"/>
        public static float FixedDelta
        {
            get => UnityTime.fixedDeltaTime;
            set => UnityTime.fixedDeltaTime = value;
        }

        /// <inheritdoc cref="UnityTime.smoothDeltaTime"/>
        public static float SmoothDelta => UnityTime.smoothDeltaTime;

        /// <inheritdoc cref="UnityTime.time"/>
        public static float Time => UnityTime.time;
        /// <inheritdoc cref="UnityTime.timeAsDouble"/>
        public static double TimeAsDouble => UnityTime.timeAsDouble;

        /// <inheritdoc cref="UnityTime.fixedTime"/>
        public static float FixedTime => UnityTime.fixedTime;
        /// <inheritdoc cref="UnityTime.fixedTimeAsDouble"/>
        public static double FixedTimeAsDouble => UnityTime.fixedTimeAsDouble;

        /// <inheritdoc cref="UnityTime.timeSinceLevelLoad"/>
        public static float SecondsSinceSceneLoad => UnityTime.timeSinceLevelLoad;
        /// <inheritdoc cref="UnityTime.timeSinceLevelLoadAsDouble"/>
        public static double SecondsSinceSceneLoadAsDouble => UnityTime.timeSinceLevelLoadAsDouble;

        /// <inheritdoc cref="UnityTime.timeScale"/>
        public static float Scale
        {
            get => UnityTime.timeScale;
            set => UnityTime.timeScale = value;
        }

        /// <inheritdoc cref="UnityTime.maximumDeltaTime"/>
        public static float MaxDelta
        {
            get => UnityTime.maximumDeltaTime;
            set => UnityTime.maximumDeltaTime = value;
        }

        /// <inheritdoc cref="UnityTime.maximumParticleDeltaTime"/>
        public static float MaxParticleDelta
        {
            get => UnityTime.maximumParticleDeltaTime;
            set => UnityTime.maximumParticleDeltaTime = value;
        }
    }

    /// <summary>
    /// Provides an interface to get wall-clock time information from Unity.
    /// </summary>
    [PublicAPI]
    public static class RealTime
    {
        /// <inheritdoc cref="UnityTime.unscaledDeltaTime"/>
        public static float Delta => UnityTime.unscaledDeltaTime;
        /// <inheritdoc cref="UnityTime.fixedUnscaledDeltaTime"/>
        public static float FixedDelta => UnityTime.fixedUnscaledDeltaTime;

        /// <inheritdoc cref="UnityTime.unscaledTime"/>
        public static float Time => UnityTime.unscaledTime;
        /// <inheritdoc cref="UnityTime.unscaledTimeAsDouble"/>
        public static double TimeAsDouble => UnityTime.unscaledTimeAsDouble;

        /// <inheritdoc cref="UnityTime.fixedUnscaledTime"/>
        public static float FixedTime => UnityTime.fixedUnscaledTime;
        /// <inheritdoc cref="UnityTime.fixedUnscaledTimeAsDouble"/>
        public static double FixedTimeAsDouble => UnityTime.fixedUnscaledTimeAsDouble;

        /// <inheritdoc cref="UnityTime.realtimeSinceStartup"/>
        public static float SecondsSinceStartup => UnityTime.realtimeSinceStartup;
        /// <inheritdoc cref="UnityTime.realtimeSinceStartupAsDouble"/>
        public static double SecondsSinceStartupAsDouble => UnityTime.realtimeSinceStartupAsDouble;
    }
}
