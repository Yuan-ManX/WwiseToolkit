// AkEvent类是Wwise Unity Integration中的一个类，用于表示Wwise中的事件（Event）。
// 下面是该类的一些重要功能：
// 1.播放Wwise Event：可以使用AkSoundEngine.PostEvent()方法播放该事件。
// 2.停止播放Wwise Event：可以使用AkSoundEngine.StopAll()方法停止播放该事件。
// 3.设置Wwise Event的播放参数：可以使用AkSoundEngine.SetRTPCValue()方法设置该事件的RTPC参数值。
// 4.获得Wwise Event的信息：可以使用AkSoundEngine.GetEventDuration()方法获得该事件的持续时间等信息。

using UnityEngine;
using System.Collections;
using AK;
using AK.Wwise;


// 使用Ak.Wwise.Event类型的myEvent变量来表示Wwise中的一个事件。
// 在Start()方法中，我们使用myEvent.Post()方法播放该事件，
// 并使用AkSoundEngine.SetRTPCValue()方法设置该事件的RTPC参数值。
// 还使用AkSoundEngine.GetEventDuration()方法获得该事件的持续时间。
// 在Update()方法中，我们使用AkSoundEngine.StopAll()方法停止播放该事件。
public class Example : MonoBehaviour
{
    public AK.Wwise.Event myEvent; // Wwise Event

    void Start()
    {
        // 播放Wwise Event
        myEvent.Post(gameObject);

        // 设置Wwise Event的RTPC参数值
        AkSoundEngine.SetRTPCValue("MyRTPC", 50.0f);

        // 获得Wwise Event的信息
        float duration = AkSoundEngine.GetEventDuration(myEvent.Id);
    }

    void Update()
    {
        // 停止播放Wwise Event
        if (Input.GetKey(KeyCode.Space))
        {
            AkSoundEngine.StopAll();
        }
    }
}

