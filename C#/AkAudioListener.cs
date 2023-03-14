// AkAudioListener是Wwise Unity Integration中的一个类，用于在Unity场景中将音频数据传递给Wwise音频引擎。
// AkAudioListener类主要功能包括：
// 1.注册和注销当前场景中的所有AkAudioListener实例
// 2.获取当前场景中所有可听到的音频源列表并计算其空间信息，如位置、方向、距离等。
// 3.将音频数据传递给Wwise音频引擎进行混音和处理。


using UnityEngine;
using AK.Wwise;

// 1.注册和注销AkAudioListener实例
public void OnEnable()
{
    // 注册当前AkAudioListener实例
    AkSoundEngine.RegisterListener(gameObject);
}

public void OnDisable()
{
    // 注销当前AkAudioListener实例
    AkSoundEngine.UnregisterListener(gameObject);
}
// 在Unity中，当AkAudioListener实例启用时，它将自动注册到Wwise音频引擎中。当实例禁用时，它将自动注销。


// 2.获取可听到的音频源列表和空间信息
public static void GetNearbySources(List<AkAmbient> akAmbients, int maxSoundPropagationDepth, Vector3 listenerPosition, out List<AkAudioSource> akAudioSources)
{
    // 获取当前场景中可听到的音频源列表，并计算其空间信息
    AkSoundEngine.GetActiveListeners(AkSoundEngine.AK_INVALID_GAME_OBJECT, listeners);

    akAudioSources = new List<AkAudioSource>();

    foreach (var akAmbient in akAmbients)
    {
        // 如果音频源已销毁，则不加入可听到列表中
        if (akAmbient == null || akAmbient.gameObject == null)
        {
            continue;
        }

        var akAudioSource = akAmbient.GetComponent<AkAudioSource>();
        if (akAudioSource != null)
        {
            // 计算音频源与听者之间的距离，如果超过最大传播深度，则不加入可听到列表中
            var distance = Vector3.Distance(listenerPosition, akAudioSource.transform.position);
            if (distance > maxSoundPropagationDepth)
            {
                continue;
            }

            // 计算音频源相对于听者的位置和方向
            var relativePosition = akAudioSource.transform.position - listenerPosition;
            var relativeRotation = Quaternion.LookRotation(relativePosition);

            akAudioSources.Add(akAudioSource);
        }
    }
}
// 这个函数主要获取场景中可听到的音频源列表，并计算它们的空间信息，包括距离、位置和方向等。
// 它还可以限制最大传播深度，以避免将太远的音频源添加到可听到列表中。