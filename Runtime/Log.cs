using System.Diagnostics;
using JetBrains.Annotations;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace FK.Common
{
    [PublicAPI]
    public static class Log
    {
        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void WithFrameInfo(string message) =>
            Debug.Log(PrefixFrameInfo(message));

        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void WithFrameInfo(string message, Object context) =>
            Debug.Log(PrefixFrameInfo(message), context);

        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void Info(string message) =>
            Debug.Log(message);

        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void Info(string message, Object context) =>
            Debug.Log(message, context);

        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void Warning(string message) =>
            Debug.LogWarning(message);

        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void Warning(string message, Object context) =>
            Debug.LogWarning(message, context);

        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void Error(string message) =>
            Debug.LogError(message);

        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void Error(string message, Object context) =>
            Debug.LogError(message, context);

        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void Exception(System.Exception exception) =>
            Debug.LogException(exception);

        // ReSharper disable Unity.PerformanceAnalysis
        [HideInCallstack, Conditional("ENABLE_LOGS")]
        public static void Exception(System.Exception exception, Object context) =>
            Debug.LogException(exception, context);

        private static string PrefixFrameInfo(string message)
        {
            string frameCount = $"<color=#669>Frame #{Time.frameCount,4}</color>";
            string deltaTimeMS = $"<color=#588>({Time.deltaTime * 1000,4:N0} ms)</color>";
            return $"{frameCount} {deltaTimeMS} {message}";
        }
    }
}
