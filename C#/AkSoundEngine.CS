// AkSoundEngine是Wwise Unity Integration中最为重要的类之一，它是Wwise引擎的主要接口之一，
// 负责处理音频播放、音频设置、音频控制等功能。下面我们将对AkSoundEngine类进行详细的解释，并给出代码和注释。
// AkSoundEngine类的主要功能包括：
// 1.音频播放：AkSoundEngine类提供了多种播放音频的方法，包括播放事件、播放游戏对象、播放音效等。
// 其中，播放事件是最常用的一种方式，可以通过AkSoundEngine.PostEvent()方法实现。
// 2.音频设置：AkSoundEngine类提供了多种音频设置的方法，包括设置监听器数量、距离衰减等。
// 这些设置可以通过AkSoundEngine.SetDefaultListeners()和AkSoundEngine.SetDefaultRTPCValue()等方法实现。
// 3.音频控制：AkSoundEngine类提供了多种音频控制的方法，包括停止播放、暂停播放、恢复播放等。
// 其中，停止播放是最常用的一种方式，可以通过AkSoundEngine.StopAll()和AkSoundEngine.StopPlayingID()等方法实现。


// AkSoundEngine是Wwise SDK中的一个重要类，它提供了一组函数来管理音频事件的播放、暂停、停止、参数控制等。
// 下面我们来详细解释AkSoundEngine类的几个常见函数，并给出相应的代码和注释。

using UnityEngine;
using AK.Wwise;


// 1.初始化引擎
// AkSoundEngine需要在游戏启动时初始化。在Unity中，通常可以在Awake函数中进行初始化。
void Awake() {
    // 初始化AkSoundEngine
    AkSoundEngine.Init();
}


// 2.播放音频事件
// 使用AkSoundEngine的PostEvent函数可以在给定的GameObject位置播放一个音频事件。
public void PlaySound(string eventName, GameObject sourceObject) {
    // 在给定GameObject的位置播放音频事件
    AkSoundEngine.PostEvent(eventName, sourceObject);
}


// 3.停止播放
// 使用AkSoundEngine的StopAll函数可以停止所有播放中的音频事件。
public void StopAllSounds() {
    // 停止所有播放中的音频事件
    AkSoundEngine.StopAll();
}


// 4.获取音频事件信息
// 可以使用AkSoundEngine的GetEventDuration函数获取指定音频事件的持续时间。
public float GetEventDuration(string eventName) {
    // 获取音频事件的持续时间
    uint eventID = AkSoundEngine.GetIDFromString(eventName);
    return AkSoundEngine.GetEventDuration(eventID);
}


// 5.设置音量
// 可以使用AkSoundEngine的SetVolume函数来设置音量。
public void SetVolume(float volume) {
    // 设置音量
    AkSoundEngine.SetRTPCValue("MasterVolume", volume);
}


// 6.设置实时参数控制器的值
// 可以使用AkSoundEngine的SetRTPCValue函数来设置实时参数控制器的值。
public void SetRTPCValue(string rtpcName, float value) {
    // 设置实时参数控制器的值
    AkSoundEngine.SetRTPCValue(rtpcName, value);
}


// 7.获取音频信息
// 可以使用AkSoundEngine的GetSourcePlayPosition函数获取指定音频源的播放位置。
public float GetSoundPlayPosition(uint playingID) {
    // 获取指定音频源的播放位置
    return AkSoundEngine.GetSourcePlayPosition(playingID);
}


// 8.更新音频引擎状态
// 可以使用AkSoundEngine的RenderAudio函数来更新音频引擎状态。
void Update() {
    // 更新音频引擎状态
    AkSoundEngine.RenderAudio();
}


// 9.注册游戏对象
// 使用AkSoundEngine的RegisterGameObj函数可以将一个GameObject注册到音频引擎中，这样可以在运行时控制该对象的声音属性。
public void RegisterGameObject(GameObject gameObject) {
    // 将GameObject注册到音频引擎中
    AkSoundEngine.RegisterGameObj(gameObject, gameObject.name);
}


// 10.设置游戏对象位置
// 可以使用AkSoundEngine的SetObjectPosition函数设置游戏对象的位置。
public void SetObjectPosition(GameObject gameObject, Vector3 position) {
    // 设置游戏对象的位置
    AkSoundEngine.SetObjectPosition(gameObject, position);
}


// 11.设置游戏对象朝向
// 可以使用AkSoundEngine的SetObjectOrientation函数设置游戏对象的朝向。
public void SetObjectOrientation(GameObject gameObject, Vector3 forward, Vector3 up) {
    // 设置游戏对象的朝向
    AkSoundEngine.SetObjectOrientation(gameObject, forward, up);
}


// 12.设置游戏对象的旋转
// 可以使用AkSoundEngine的SetObjectRotation函数设置游戏对象的旋转。
public void SetObjectRotation(GameObject gameObject, Quaternion rotation) {
    // 设置游戏对象的旋转
    AkSoundEngine.SetObjectRotation(gameObject, rotation);
}


// 13.设置环境信息
// 可以使用AkSoundEngine的SetEnvironment函数设置环境信息，以影响音频的声音属性。
public void SetEnvironment(AkEnvironment environment) {
    // 设置环境信息
    AkSoundEngine.SetEnvironment(environment.gameObject, environment.ID);
}


// 14.获取音频引擎信息
// 可以使用AkSoundEngine的GetDefaultOutputDevice函数获取音频引擎当前默认的输出设备。
public string GetDefaultOutputDevice() {
    // 获取默认的输出设备
    StringBuilder deviceName = new StringBuilder(256);
    uint deviceID = AkSoundEngine.GetDefaultOutputDeviceID();
    AkSoundEngine.GetDeviceOutputChannelConfig(deviceID, deviceName, (uint)deviceName.Capacity);
    return deviceName.ToString();
}


// 15.设置音量
// 可以使用AkSoundEngine的SetVolume函数设置音量大小。
public void SetVolume(float volume) {
    // 设置音量大小
    AkSoundEngine.SetVolume(AkSoundEngine.GetDefaultGameObject(), volume);
}


// 16.暂停/恢复播放
// 可以使用AkSoundEngine的SetAllListenersEnabled函数控制所有听众（listener）是否接收音频。
public void PauseAll(bool pause) {
    // 暂停/恢复播放
    AkSoundEngine.SetAllListenersEnabled(!pause);
}


// 17.停止播放
// 可以使用AkSoundEngine的StopAll函数停止所有正在播放的音频。
public void StopAll() {
    // 停止所有正在播放的音频
    AkSoundEngine.StopAll();
}


// 18.按名称播放音频
// 可以使用AkSoundEngine的PostEvent函数按名称播放音频。
public void PlaySound(string eventName) {
    // 播放指定名称的音频
    AkSoundEngine.PostEvent(eventName, AkSoundEngine.GetDefaultGameObject());
}


// 19.按ID播放音频
// 可以使用AkSoundEngine的PostEvent函数按ID播放音频。
public void PlaySound(uint eventID) {
    // 播放指定ID的音频
    AkSoundEngine.PostEvent(eventID, AkSoundEngine.GetDefaultGameObject());
}


// 20.停止播放指定音频
// 可以使用AkSoundEngine的StopPlayingID函数停止播放指定ID的音频。
public void StopSound(uint eventID) {
    // 停止播放指定ID的音频
    AkSoundEngine.StopPlayingID(eventID);
}


// 21.获取音频状态
// 可以使用AkSoundEngine的GetSourcePlayPosition函数获取指定音频的播放位置。
public float GetSoundPlayPosition(uint eventID) {
    // 获取指定ID的音频的播放位置
    return AkSoundEngine.GetSourcePlayPosition(eventID);
}