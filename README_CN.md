# WwiseToolkit

WwiseToolkit主要包括Wwise SDK、Wwise Unity Integration、WAAPI和Unity Component四个部分。

Wwise SDK、Wwise Unity Integration、WAAPI和Unity Component是四个不同的工具，各自有不同的功能和用途。以下是它们的内容：

## 1.Wwise SDK (C++)

Wwise SDK是一款适用于游戏开发者的音频引擎软件开发工具包，它提供了一系列功能和API，使开发者能够在游戏中实现高质量的音频效果。Wwise SDK包含了丰富的音频处理和管理功能，如音频事件的创建、音频轨道的混合和过渡、音频效果的应用等等。通过使用Wwise SDK，开发者可以轻松地管理游戏中的所有音频内容。

Wwise SDK 提供了多种编程语言和框架的 API，下面是一些常用的 Wwise SDK C++ API：

1. AK::SoundEngine API：Sound Engine API 是 Wwise SDK 最常用和最核心的 API 之一，它包含了各种音频效果和控制函数，可以实现音效的播放、停止、暂停、淡入淡出、3D 空间化、实时混音等功能。
2. AK::Event API：Event API 允许开发者定义和触发各种音频事件，例如播放音效、暂停音效、停止音效等等。通过 Event API，开发者可以实现音频动态交互效果，如玩家角色移动时，背景音乐根据距离和方向变化等。
3. AK::SoundBank API：SoundBank API 允许开发者管理和操作音频资源，例如加载、卸载和预加载音频资源，以及获取音频资源的详细信息。通过 SoundBank API，开发者可以实现更高效的音频资源管理和控制。
4. AK::Plugin API：Plugin API 允许开发者创建和使用自定义的音频效果插件，例如混响、均衡器、压缩器等。通过 Plugin API，开发者可以扩展 Wwise SDK 的音频效果功能，并实现更加个性化和高品质的音效。
5. AK::MemoryMgr API：MemoryMgr API 允许开发者管理和控制 Wwise SDK 中的内存分配和释放。通过 MemoryMgr API，开发者可以实现更加灵活的内存管理策略，以提高应用程序的性能和稳定性。
6. AK::PluginContext API：PluginContext API 允许开发者在插件中访问音频数据、参数、输入输出缓冲区等。通过 PluginContext API，开发者可以实现更加个性化和高效的音频处理，例如自定义的音频效果、声音识别等
7. AK::BankManager API：BankManager API 允许开发者管理和操作 Wwise 音频工程中的 SoundBank。通过 BankManager API，开发者可以实现更加灵活的 SoundBank 管理，例如加载 SoundBank、卸载 SoundBank、预加载 SoundBank 等。
8. AK::Metering API：Metering API 允许开发者获取音频信号的级别、峰值、频谱等信息。通过 Metering API，开发者可以实现更加精准和高效的音频分析和处理，例如音量自动调节、声音检测等。
9. AK::Query API：Query API 允许开发者查询各种音频属性，例如音频文件格式、音频时长、音频采样率等。通过 Query API，开发者可以实现更加精准和高效的音频分析和处理，例如音频文件格式的自适应处理、音频时长的自动调整等。
10. AK::Thread API：Thread API 允许开发者创建和管理线程，以实现更加复杂和高效的音频处理。通过 Thread API，开发者可以实现并行处理、异步处理等功能，以提高应用程序的性能和稳定性。
11. AK::PluginParam API：PluginParam API 允许开发者在插件中定义和管理插件参数，例如插件的各种参数、参数类型、范围等。通过 PluginParam API，开发者可以实现更加个性化和高效的插件参数管理，以提高插件的灵活性和可扩展性。
12. AK::MusicEngine API：MusicEngine API 允许开发者实现游戏中的音乐交互和控制，例如根据玩家行为、游戏状态等动态变化音乐的节奏、曲调、音量等。通过 MusicEngine API，开发者可以实现更加个性化和精准的音乐交互效果，提高游戏的乐趣和体验。
13. AK::SpatialAudio API：SpatialAudio API 允许开发者实现 3D 音效和环绕声效果，例如将声音位置化、距离衰减、方向和角度变化等。通过 SpatialAudio API，开发者可以实现更加逼真和生动的游戏音效和环境音效，提高游戏的沉浸感和真实感。
14. AK::PluginServices API：PluginServices API 允许开发者访问 Wwise SDK 中的各种服务和资源，例如获取音频文件、处理参数、设置属性等。通过 PluginServices API，开发者可以实现更加灵活和高效的插件开发，以满足不同的音频处理需求。
15. AK::StreamMgr API：StreamMgr API 允许开发者管理和控制音频数据的读取和写入，例如通过网络、磁盘、内存等方式读取和写入音频数据。通过 StreamMgr API，开发者可以实现更加灵活和高效的音频数据管理，以提高应用程序的性能和稳定性。

以上是一些常用的 Wwise SDK C++ API，它们提供了丰富的音频处理和控制功能，帮助开发者实现高质量的音频效果和交互。

## 2.Wwise Unity Integration (C#)

Wwise Unity Integration是一款基于Unity引擎的插件，用于将Wwise SDK集成到Unity项目中。它提供了许多工具和功能，使开发者能够在Unity中使用Wwise SDK的所有功能。Wwise Unity Integration允许开发者在Unity编辑器中创建、编辑和管理Wwise音频事件，以及在运行时播放、控制和修改Wwise音频事件的参数。通过使用Wwise Unity Integration，开发者可以轻松地将Wwise音频引擎集成到Unity游戏中，实现高质量的音频效果。

Wwise Unity Integration中的类非常多，涵盖了从音频事件管理到音频效果处理等各个方面。下面列出一些常用的类并简要介绍它们的功能和使用方法：

1. AkInitializer类：该类用于初始化和连接Wwise引擎与Unity引擎，可以设置全局音频设置、预加载音频事件等。
2. AkBankManager类：该类用于管理Wwise资源包，可以加载和卸载资源包、查询资源包状态等。
3. AkSoundEngine类：该类用于控制Wwise引擎，可以播放、暂停、停止音频事件，设置音频参数等。
4. AkEvent类：该类代表Wwise音频事件，可以通过调用Play()方法播放音频事件，设置音频参数等。
5. AkGameObj：这个类用于表示Wwise声音源的游戏对象，并提供对游戏对象的管理和控制操作。
6. AkAudioListener类：该类代表Wwise监听器，可以在场景中添加多个监听器，并通过选择不同的监听器来实现3D声音定位。
7. AkAudioSource类：该类代表Wwise音频源，可以在场景中添加多个音频源，并将它们绑定到AkEvent上，以控制音频播放。
8. AkRoomPortal类：该类代表Wwise房间门，可以通过将它们添加到场景中来实现声音在不同房间之间的传递。
9. AkState和AkSwitch类：这两个类用于管理Wwise状态和开关，可以通过它们实现音频事件的动态变化。
10. AkEnvironment类：该类代表Wwise环境，可以通过选择不同的环境来模拟不同的音效处理，如混响、EQ等。
11. AkAuxSendArray和AkAuxSendValue类：这两个类用于管理Wwise混响和延迟效果，可以控制音频事件的混响和延迟效果。

对于不同的需求，可以选择不同的类来实现所需功能。总的来说，Wwise Unity Integration提供了非常丰富的类库，可以满足开发者在音频方面的各种需求。

## 3.WAAPI

WAAPI（Wwise Authoring API）是一组API，用于通过编程方式与Wwise项目进行交互和管理。WAAPI可以用于自动化音频内容的创建、管理和导出，以及与第三方工具的集成。通过使用WAAPI，开发者可以轻松地进行批量处理、自动化流程、自定义工作流程等等，以提高生产效率和降低出错率。WAAPI可以与Wwise SDK和Wwise Unity Integration一起使用，以便更方便地管理和控制Wwise项目中的音频内容。

## 4.Unity Component

Unity中的Component指的是游戏对象中的组件，它是实现游戏逻辑和功能的基本单元。每个组件都有自己的属性和方法，通过这些属性和方法来控制游戏对象的行为。

在Unity中，有很多常用的组件，包括Transform、MeshRenderer、Collider、Rigidbody等等。下面分别介绍一下这些组件的作用和常用属性：

1. Transform组件：Transform组件控制游戏对象的位置、旋转和缩放。常用的属性有position、rotation和scale。
2. MeshRenderer组件：MeshRenderer组件用于渲染游戏对象的模型，可以设置材质和纹理等属性。
3. Collider组件：Collider组件用于检测游戏对象的碰撞，包括盒子碰撞器(BoxCollider)、球形碰撞器(SphereCollider)、胶囊碰撞器(CapsuleCollider)等。
4. Rigidbody组件：Rigidbody组件用于控制游戏对象的物理运动，可以设置质量、重力等属性。
5. AudioSource组件：AudioSource组件用于播放声音，可以设置音量、音调等属性。
6. Animator组件：Animator组件用于控制游戏对象的动画，可以创建动画控制器(Animator Controller)来管理游戏对象的动画过渡和触发条件。
7. ParticleSystem组件：ParticleSystem组件用于创建粒子效果，可以设置粒子的形状、颜色、速度等属性，以及通过脚本来控制粒子的生命周期。
8. Light组件：Light组件用于创建光源，可以设置光源的类型、颜色、强度等属性。
9. Camera组件：Camera组件用于创建摄像机，可以控制摄像机的位置、旋转、视角等属性，以及通过脚本来控制摄像机的运动。
10. Canvas组件：Canvas组件用于创建UI界面，可以添加按钮、文本、图片等UI元素，并通过脚本来控制它们的行为和显示状态。

除了这些常用的组件外，Unity还有很多其他的组件，每个组件都有自己的功能和属性，可以通过组合不同的组件来实现复杂的游戏逻辑和效果。Unity中的Component是非常重要的，熟练掌握这些组件的使用，可以让开发者更加高效地创建出优秀的游戏。

综上所述，Wwise SDK、Wwise Unity Integration、WAAPI和Unity Component是四个不同的工具，各自有不同的功能和用途。Wwise SDK提供了一系列功能和API，用于实现高质量的音频效果；Wwise Unity Integration用于将Wwise SDK集成到Unity项目中，以便在Unity中使用Wwise SDK的所有功能；WAAPI则用于通过编程方式与Wwise项目进行交互和管理，以提高生产效率和降低出错率。开发者可以根据实际需求选择使用其中的一个或多个工具。
