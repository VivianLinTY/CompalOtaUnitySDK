using System;
using UnityEngine;

namespace OtaSdk.Client
{
    public class OtaSdkUtils
    {
        private readonly static string TAG = "[OtaSdkUtils]";

        public static void registerOtaCallback(IOtaSdkCallback callback)
        {
            if (null == Log.Instance)
            {
                Log.CreateInstance(true);
            }

            Log.Instance.V(TAG, "registerSystemMessage");
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaClass proxyClass = new AndroidJavaClass("com.compal.otasdk.OtaUnityProxy");
            proxyClass.CallStatic("registerOtaCallback", activity, callback);
        }

        public static void unRegisterOtaCallback(IOtaSdkCallback callback)
        {
            Log.Instance.V(TAG, "unRegisterSystemMessage");
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaClass proxyClass = new AndroidJavaClass("com.compal.otasdk.OtaUnityProxy");
            proxyClass.CallStatic("unRegisterOtaCallback", activity, callback);
        }

        public static bool newVersionCheck()
        {
            Log.Instance.V(TAG, "newVersionCheck");
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaClass proxyClass = new AndroidJavaClass("com.compal.otasdk.OtaUnityProxy");
            return proxyClass.CallStatic<bool>("newVersionCheck");
        }

        public static bool startDownload()
        {
            Log.Instance.V(TAG, "startDownload");
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaClass proxyClass = new AndroidJavaClass("com.compal.otasdk.OtaUnityProxy");
            return proxyClass.CallStatic<bool>("startDownload");
        }
    }
}