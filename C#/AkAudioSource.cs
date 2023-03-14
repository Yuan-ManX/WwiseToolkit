// AkAudioSource类是Wwise Unity Integration中的一个类，
// 它是Unity的AudioSource类的一个子类，用于将Wwise音频引擎和Unity的音频系统进行集成。
// 下面是该类的一些重要功能：
// 1.播放Wwise音频：可以使用AkAudioSource.Post()方法播放音频。
// 2.设置音频的播放参数：可以使用AkAudioSource.SetRTPCValue()方法设置音频的RTPC参数值。
// 3.获得音频的信息：可以使用AkAudioSource.GetDuration()方法获得音频的持续时间等信息。


using UnityEngine;
using System.Collections;
using AK;
using AK.Wwise;


// 使用AkAudioSource类型的myAudioSource变量来表示Wwise AudioSource。
// 在Start()方法中，我们设置myAudioSource的eventID为myEvent的ID，
// 并使用myAudioSource.Post()方法播放音频。
// 使用myAudioSource.SetRTPCValue()方法设置音频的RTPC参数值，
// 并使用myAudioSource.GetDuration()方法获得音频的持续时间。
// 在Update()方法中，我们使用myAudioSource.Stop()方法停止播放音频。
public class Example : MonoBehaviour
{
    public AK.Wwise.Event myEvent; // Wwise Event
    public AkAudioSource myAudioSource; // Wwise AudioSource

    void Start()
    {
        // 设置Wwise AudioSource
        myAudioSource.eventID = myEvent.Id;

        // 播放Wwise音频
        myAudioSource.Post(gameObject);

        // 设置Wwise音频的RTPC参数值
        myAudioSource.SetRTPCValue("MyRTPC", 50.0f);

        // 获得Wwise音频的信息
        float duration = myAudioSource.GetDuration();
    }

    void Update()
    {
        // 停止播放Wwise音频
        if (Input.GetKey(KeyCode.Space))
        {
            myAudioSource.Stop();
        }
    }
}
