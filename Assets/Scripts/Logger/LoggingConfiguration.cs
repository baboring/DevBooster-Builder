using UnityEngine;
using System.IO;


namespace NineD77.Log
{
    public static class LoggingConfiguration
    {
        private static string _fileName => $"{Application.dataPath}/Config/UnityDebug.log4net";

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Configure()
        {
            if (!DevBoost.Utilities.Logger.Init(new FileInfo(_fileName)))
                Debug.LogError($"{_fileName} not found");
        }
    }

}