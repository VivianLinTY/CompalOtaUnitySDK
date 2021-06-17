using UnityEngine;

namespace OtaSdk.Client
{
    abstract public class IOtaSdkCallback : AndroidJavaProxy
    {
        public IOtaSdkCallback() : base("com.compal.otasdk.IOtaSdkCallback")
        {
        }

        abstract public void onRegisterSuccess(bool success);

        abstract public void onNewVersion(bool hasNewVersion, string version);

        abstract public void onDownloadProgress(int progress);

        abstract public void onDownloadResult(bool success);

        abstract public void onUpgradeStatus(bool success);
    }
}