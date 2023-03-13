// AkBankManager是Wwise Unity集成中用于管理bank文件（.bnk）和音效预制体的单例类，
// 它的主要功能包括加载和卸载bank文件，以及获取音效预制体等。下面是AkBankManager的主要功能：

using UnityEngine;
using AK.Wwise;


// 1.加载bank文件
// 可以使用AkBankManager的LoadBank函数加载指定名称的bank文件，例如加载名为"SoundBank"的bank文件。
public void LoadSoundBank() {
    // 加载名为"SoundBank"的bank文件
    AkBankManager.LoadBank("SoundBank", false, false);
}

// "SoundBank"表示bank文件的名称，第二个参数表示是否等待加载完成，第三个参数表示是否打印日志信息。


// 2.卸载bank文件
// 可以使用AkBankManager的UnloadBank函数卸载指定名称的bank文件，例如卸载名为"SoundBank"的bank文件。
public void UnloadSoundBank() {
    // 卸载名为"SoundBank"的bank文件
    AkBankManager.UnloadBank("SoundBank", false, false);
}

// "SoundBank"表示bank文件的名称，第二个参数表示是否等待卸载完成，第三个参数表示是否打印日志信息。


// 3.加载预制体音效
// 可以使用AkBankManager的LoadGameObjectAsync函数加载指定名称的预制体音效,例如加载名为"Explosion"的预制体音效。
public void LoadExplosion() {
    // 加载名为"Explosion"的预制体音效
    AkBankManager.LoadGameObjectAsync("Explosion", null, null, null);
}
// "Explosion"表示预制体音效的名称，后面的参数可以设置加载完成的回调、卸载完成的回调和加载失败的回调。


// 4.卸载预制体音效
// 可以使用AkBankManager的UnloadGameObject函数卸载指定名称的预制体音效，例如卸载名为"Explosion"的预制体音效。
public void UnloadExplosion() {
    // 卸载名为"Explosion"的预制体音效
    AkBankManager.UnloadGameObject("Explosion");
}
// "Explosion"表示预制体音效的名称。


// 5.获取预制体音效
// 可以使用AkBankManager的GetAkGameObj函数获取指定名称的预制体音效，例如获取名为"Explosion"的预制体音效。
public GameObject GetExplosion() {
    // 获取名为"Explosion"的预制体音效
    return AkBankManager.GetAkGameObj("Explosion");
}
// "Explosion"表示预制体音效的名称。


// 6.设置bank文件的语言
// 可以使用AkBankManager的SetCurrentLanguage函数设置bank文件的语言，例如设置bank文件的语言为"English(US)"。
public void SetBankLanguage() {
    // 设置银行文件的语言为"English(US)"
    AkBankManager.SetCurrentLanguage("English(US)");
}
// "English(US)"表示要设置的语言名称。


// 7.获取bank文件状态
// 可以使用AkBankManager的GetBankLoadState函数获取指定名称的bank文件的加载状态，例如获取名为"SoundBank"的bank文件的加载状态。
public AkBankManager.BankLoadState GetSoundBankLoadState() {
    // 获取名为"SoundBank"的bank文件的加载状态
    return AkBankManager.GetBankLoadState("SoundBank");
}
// "SoundBank"表示bank文件的名称。


// 8.预加载bank文件
// 在游戏运行时，如果需要使用某个bank文件中的音效预制体，可以通过预加载bank文件，
// 使其提前加载到内存中，以减少游戏运行时的加载时间和延迟。
// 可以使用AkBankManager的LoadBank函数进行预加载。
public void PreloadSoundBank() {
    // 预加载名为"SoundBank"的bank文件
    AkBankManager.LoadBank("SoundBank", true, true);
}
// 第一个参数"SoundBank"表示要预加载的bank文件名称，第二个参数为true表示要异步加载，
// 第三个参数为true表示要自动卸载需要注意的是，预加载银行文件需要一定时间，
// 因此最好在游戏启动时或关卡切换时进行预加载，以充分利用加载时间。


// 9.卸载bank文件
// 在游戏运行过程中，如果不再需要使用某个bank文件中的音效预制体，
// 可以使用AkBankManager的UnloadBank函数进行卸载，以释放内存资源。
public void UnloadSoundBank() {
    // 卸载名为"SoundBank"的bank文件
    AkBankManager.UnloadBank("SoundBank", IntPtr.Zero);
}
// 第一个参数"SoundBank"表示要卸载的bank文件名称，
// 第二个参数为IntPtr.Zero表示卸载所有语言版本的bank文件。
// 需要注意的是，如果音效预制体仍在使用中，则卸载bank文件可能会导致音效无法播放。


// 10获取bank文件列表
// 可以使用AkBankManager的GetBankList函数获取当前加载的所有bank文件的名称。
public List<string> GetBankList() {
    // 获取当前加载的所有bank文件的名称列表
    return AkBankManager.GetBankList();
}
// 返回值是一个字符串列表，包含当前加载的所有bank文件的名称。


// 11.获取bank文件加载状态
// 可以使用AkBankManager的GetBankLoadState函数获取指定bank文件的加载状态。
public AkBankManager.BankLoadState GetBankLoadState() {
    // 获取名为"SoundBank"的bank文件的加载状态
    return AkBankManager.GetBankLoadState("SoundBank");
}
// 第一个参数"SoundBank"表示要获取的bank文件名称，返回值是一个枚举类型的BankLoadState，包括以下四种状态：
// NotLoaded：未加载
// Loading：正在加载
// Loaded：已加载
// Unloading：正在卸载
// 需要注意的是，如果bank文件异步加载，则在调用GetBankLoadState函数时可能会返回Loading状态，直到加载完成为止。


// 12.设置bank文件路径
// 可以使用AkBankManager的SetBasePath函数设置bank文件的基本路径。
public void SetBankPath() {
    // 设置bank文件的基本路径为StreamingAssets文件夹
    AkBankManager.SetBasePath(Application.streamingAssetsPath);
}
// 第一个参数Application.streamingAssetsPath表示要设置的路径，返回值为无。
// 需要注意的是，bank文件的路径设置应该在游戏启动时进行，以便正确加载bank文件。

