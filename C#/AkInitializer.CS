// AkInitializer类的作用不仅限于初始化和连接Wwise引擎与Unity引擎，它还可以实现一些其他的功能，
// 例如：
// 1.配置全局音频设置：AkInitializer类可以在Awake()方法中调用AkSoundEngine.SetDefaultListeners()方法
// 设置全局音频设置，如监听器数量、距离衰减等。
// 2.实现音频事件预加载：AkInitializer类可以在Awake()方法中调用AkBankManager.LoadBank()方法
// 预加载音频事件，以减少游戏运行时的加载延迟。
// 3.优化Wwise引擎性能：AkInitializer类可以在Awake()方法中调用
// AkSoundEngineController.SetOutputSettings()方法设置Wwise引擎的输出设置，以优化其性能表现。

using UnityEngine;
using AK.Wwise;

public class AkInitializer : MonoBehaviour
{
    // Wwise配置文件的路径
    public string WwiseConfigFilePath = "WwiseConfig.akp";

    // 监听器数量
    public int ListenerCount = 1;

    // 距离衰减
    public float DistanceAttenuation = 1.0f;

    // 音频事件预加载
    public AkBankLoader[] BankLoaders;

    // Unity项目启动时执行
    void Awake()
    {
        // 检查Wwise引擎是否已经初始化
        if (AkSoundEngine.IsInitialized())
        {
            return;
        }

        // 初始化Wwise引擎
        AkSoundEngineController.Init(WwiseConfigFilePath);

        // 设置全局音频设置
        AkSoundEngine.SetDefaultListeners(ListenerCount);
        AkSoundEngine.SetDefaultRTPCValue("DistanceAttenuation", DistanceAttenuation);

        // 预加载音频事件
        if (BankLoaders != null)
        {
            foreach (AkBankLoader bankLoader in BankLoaders)
            {
                bankLoader.Load();
            }
        }

        // 将Wwise引擎与Unity引擎进行连接
        AkIntegrationBehavior[] integrationBehaviors = FindObjectsOfType<AkIntegrationBehavior>();
        foreach (AkIntegrationBehavior integrationBehavior in integrationBehaviors)
        {
            integrationBehavior.Awake();
        }

        // 设置Wwise引擎输出设置
        AkSoundEngineController.SetOutputSettings();
    }

    // Unity项目退出时执行
    void OnApplicationQuit()
    {
        // 关闭Wwise引擎
        AkSoundEngineController.Term();
    }
}
