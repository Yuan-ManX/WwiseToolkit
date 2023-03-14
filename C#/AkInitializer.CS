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

// AkInitializer是Wwise Unity集成中用于初始化Wwise引擎的类，可以用于设置Wwise的参数、初始化声音引擎等操作。


// 1.设置Wwise项目名称
// 可以使用AkInitializer的WwiseProjectName属性设置Wwise项目的名称。
public void SetWwiseProjectName() {
    // 设置Wwise项目的名称为"ExampleProject"
    AkInitializer.WwiseProjectName = "ExampleProject";
}
// 其中，第一个参数"ExampleProject"表示要设置的Wwise项目名称，返回值为无。


// 2.设置Wwise平台
// 可以使用AkInitializer的TargetPlatform属性设置Wwise要运行的平台。
public void SetWwiseTargetPlatform() {
    // 设置Wwise要运行的平台为Windows
    AkInitializer.TargetPlatform = AkPluginActivator.PlatformID.Windows;
}
// 其中，第一个参数AkPluginActivator.PlatformID.Windows表示要设置的平台类型，返回值为无。
// 需要注意的是，Wwise支持多种平台类型，开发人员应该根据实际情况设置。


// 3.初始化Wwise引擎
// 可以使用AkInitializer的Initialize函数初始化Wwise引擎。
public void InitWwiseEngine() {
    // 初始化Wwise引擎
    AkInitializer.Initialize();
}
// 其中，返回值为无。需要注意的是，初始化Wwise引擎应该在游戏启动时进行，以便正确加载和播放银行文件和音效预制体。


// 4.设置全局语言版本
// 可以使用AkInitializer的SetCurrentLanguage函数设置当前使用的全局语言版本。
public void SetGlobalLanguage() {
    // 设置当前使用的全局语言版本为"English(US)"
    AkInitializer.SetCurrentLanguage("English(US)");
}
// 其中，第一个参数"English(US)"表示要设置的语言版本，返回值为无。需要注意的是，全局语言版本的设置可以影响到银行文件的加载和播放。


// 5.设置音频输出设备
// 可以使用AkInitializer的AudioDeviceSettings属性设置音频输出设备。
public void SetAudioDeviceSettings() {
    // 设置音频输出设备为主音频输出
    AkDeviceSettings deviceSettings = new AkDeviceSettings();
    deviceSettings.uNumSamplesPerFrame = 2048;
    deviceSettings.idAudioDevice = 0;
    deviceSettings.eCategory = AkAudioDeviceCategory.AkAudioDeviceCategory_Main;
    AkInitializer.AudioDeviceSettings = deviceSettings;
}
// 其中，第一个参数deviceSettings表示要设置的音频输出设备，返回值为无。需要注意的是，音频输出设备的设置应该根据实际情况进行，以保证音频的正常播放。


// 6.设置Wwise的初始化参数
// 可以使用AkInitializer的InitializationSettings属性设置Wwise引擎的初始化参数。
public void SetInitializationSettings() {
    // 设置Wwise引擎的初始化参数
    AkInitializationSettings settings = new AkInitializationSettings();
    settings.uMaxNumPaths = 32;
    settings.uDefaultPoolSize = 8 * 1024 * 1024;
    settings.uCommandQueueSize = 4 * 1024 * 1024;
    settings.uNumSamplesPerFrame = 2048;
    settings.fDefaultPoolRatioThreshold = 0.6f;
    settings.uMonitorQueuePoolSize = 1 * 1024 * 1024;
    AkInitializer.InitializationSettings = settings;
}
// 第一个参数settings表示要设置的初始化参数，返回值为无。需要注意的是，设置Wwise引擎的初始化参数可以影响到Wwise引擎的性能和资源消耗。


// 7.获取Wwise引擎状态
// 可以使用AkInitializer的GetEngineStatus函数获取Wwise引擎的状态。
public void GetEngineStatus() {
    // 获取Wwise引擎的状态
    AkEngineController akEngineController = AkInitializer.GetEngineController();
    Debug.Log("Wwise引擎状态：" + akEngineController.EngineStatus);
}
// 返回值为Wwise引擎的状态。需要注意的是，获取Wwise引擎状态可以帮助开发人员检查Wwise引擎的运行情况。


// 8.设置插件路径
// 可以使用AkInitializer的PluginPath属性设置插件路径。
public void SetPluginPath() {
    // 设置插件路径
    AkInitializer.PluginPath = "Assets/Plugins/Wwise/Plugins";
}
// 第一个参数"Assets/Plugins/Wwise/Plugins"表示要设置的插件路径，返回值为无。
// 需要注意的是，设置插件路径可以保证Wwise插件正确加载。


// 9.获取Wwise引擎版本号
// 可以使用AkInitializer的GetWwiseVersion函数获取当前Wwise引擎的版本号。
public void GetWwiseVersion() {
    // 获取Wwise引擎的版本号
    string wwiseVersion = AkInitializer.GetWwiseVersion();
    Debug.Log("Wwise引擎版本号：" + wwiseVersion);
}
// 返回值为当前Wwise引擎的版本号。需要注意的是，获取Wwise引擎版本号可以帮助开发人员了解当前使用的Wwise版本信息。


// 10.开启或关闭音频引擎
// 可以使用AkInitializer的EnableAudioEngine函数开启或关闭音频引擎。
public void EnableAudioEngine(bool enable) {
    // 开启或关闭音频引擎
    AkInitializer.EnableAudioEngine(enable);
}
// 第一个参数enable表示是否开启音频引擎，返回值为无。需要注意的是，开启或关闭音频引擎可以控制Wwise引擎是否产生音频输出。


// 11.设置游戏对象的输出总线
// 可以使用AkInitializer的SetOutputBus函数设置游戏对象的输出总线。
public void SetOutputBus(GameObject gameObject, string busName) {
    // 设置游戏对象的输出总线
    AkInitializer.SetOutputBus(gameObject, busName);
}
// 第一个参数gameObject表示要设置输出总线的游戏对象，第二个参数busName表示要设置的输出总线名称，返回值为无。
// 需要注意的是，设置游戏对象的输出总线可以帮助开发人员控制游戏对象的音频输出。


// 12.获取音频输出设备名称列表
// 可以使用AkInitializer的GetOutputDeviceList函数获取音频输出设备名称列表。
public void GetOutputDeviceList() {
    // 获取音频输出设备名称列表
    List<string> outputDeviceList = AkInitializer.GetOutputDeviceList();
    foreach (string deviceName in outputDeviceList) {
        Debug.Log("音频输出设备名称：" + deviceName);
    }
}
// 返回值为音频输出设备名称列表，可以帮助开发人员了解当前可用的音频输出设备信息。


// 13.设置音频输出设备
// 可以使用AkInitializer的SetOutputDevice函数设置音频输出设备。
public void SetOutputDevice(string deviceName) {
    // 设置音频输出设备
    AkInitializer.SetOutputDevice(deviceName);
}
// 第一个参数deviceName表示要设置的音频输出设备名称，返回值为无。
// 需要注意的是，设置音频输出设备可以帮助开发人员调试音频输出相关的问题。


// 14.获取Wwise全局语言版本
// 可以使用AkInitializer的GetLanguage函数获取Wwise全局语言版本。
public void GetLanguage() {
    // 获取Wwise全局语言版本
    string language = AkInitializer.GetLanguage();
    Debug.Log("Wwise全局语言版本：" + language);
}
// 返回值为当前Wwise全局语言版本，可以帮助开发人员了解当前使用的Wwise语言版本信息。


// 15.设置Wwise全局语言版本
// 可以使用AkInitializer的SetLanguage函数设置Wwise全局语言版本。
public void SetLanguage(string language) {
    // 设置Wwise全局语言版本
    AkInitializer.SetLanguage(language);
}
// 第一个参数language表示要设置的Wwise全局语言版本，返回值为无。
// 需要注意的是，设置Wwise全局语言版本可以帮助开发人员控制Wwise引擎使用的语言版本。


// 综上所述，AkInitializer是Wwise Unity集成中用于初始化Wwise引擎的重要类，提供了多种功能，
// 包括设置Wwise项目名称、Wwise平台、全局语言版本、音频输出设备、初始化参数、插件路径、
// 获取Wwise引擎状态、获取Wwise引擎版本号、开启或关闭音频引擎、设置游戏对象的输出总线、
// 获取音频输出设备名称列表、设置音频输出设备、获取Wwise全局语言版本、设置Wwise全局语言版本等。
// 开发人员可以根据实际情况进行设置，以保证Wwise引擎的正常运行。