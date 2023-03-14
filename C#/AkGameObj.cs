// AkGameObj是Wwise Unity Integration提供的一个类，用于处理Unity场景中的游戏对象，
// 使其与Wwise交互并播放音频。其主要功能包括以下几个方面：
// 1.将Unity场景中的游戏对象与Wwise中的音频事件关联起来
// 2.控制游戏对象的位置和方向信息，以便Wwise可以应用3D音效
// 3.提供接口让开发者可以在代码中控制游戏对象的音频播放和停止


using UnityEngine;
using System.Collections;
using AK;

// AkGameObj：Wwise Unity Integration提供的类，用于处理Unity场景中的游戏对象。
// eventName：在Wwise工程中定义的音频事件名称。
// position和forward：游戏对象的位置和旋转信息，用于应用3D音效。
// akGameObj：AkGameObj对象，用于控制游戏对象与Wwise的交互。
// Start()函数：在对象被实例化时，获取AkGameObj对象。
// Update()函数：每帧更新游戏对象的位置和旋转信息，将其应用到AkGameObj对象中。
// PlayEvent()函数：触发音频事件，将其在AkSoundEngine中播放。
// StopEvent()函数：停止音频事件，将其在AkSoundEngine中停止播放
public class ExampleAkGameObj : MonoBehaviour {
    
    // 在Wwise工程中定义的音频事件名称
    public string eventName;
    
    // 游戏对象的位置和旋转信息
    private Vector3 position;
    private Vector3 forward;
    
    // AkGameObj对象
    private AkGameObj akGameObj;

    void Start () {
        // 获取AkGameObj对象
        akGameObj = GetComponent<AkGameObj> ();
    }

    void Update () {
        // 获取游戏对象的位置和旋转信息
        position = transform.position;
        forward = transform.forward;

        // 更新AkGameObj对象的位置和旋转信息
        akGameObj.SetPosition (position);
        akGameObj.SetForward (forward);
    }

    // 播放音频事件
    public void PlayEvent() {
        // 在AkSoundEngine中触发音频事件
        AkSoundEngine.PostEvent (eventName, gameObject);
    }

    // 停止音频事件
    public void StopEvent() {
        // 在AkSoundEngine中停止音频事件
        AkSoundEngine.StopAll (gameObject);
    }
}
