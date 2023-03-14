// AkRoomPortal是Wwise Unity Integration中的一个类，代表了房间门。
// 在Wwise中，房间门是可以在房间之间传递声音的门。
// 在Unity中，AkRoomPortal可以让声音穿过它的边界，从一个房间传到另一个房间。

// AkRoomPortal的主要功能包括：
// 1.激活或禁用AkRoomPortal：可以使用SetActive方法来激活或禁用AkRoomPortal，这会影响到房间门是否开启或关闭。当禁用时，房间门将不允许声音通过，从而阻止声音传播。

// 2.设置房间门的大小：可以使用PortalTrigger和PortalAuxSendParams属性来设置房间门的大小。
// PortalTrigger用于指定房间门的触发器大小，而PortalAuxSendParams用于设置房间门的辅助发送参数，
// 以控制声音在通过门时的音量、EQ等。

// 3.控制房间门的传送行为：可以使用PortalTransmit和PortalMirror属性来控制房间门的传送行为。
// PortalTransmit用于指定房间门是否允许声音从房间门的一侧通过到另一侧，
// 而PortalMirror用于指定房间门是否应该反射声音，将其传回原始房间。


using UnityEngine;
using AK.Wwise.Unity;

// 首先获取了AkRoomPortal组件，并使用public属性来设置房间门的参数。
// 然后，我们使用组件的方法来设置房间门的参数，并使用SetActive方法来激活房间门。
// 在运行时，声音将可以从一个房间穿过房间门，到达另一个房间。
public class PortalExample : MonoBehaviours
{
    // 设置房间门大小的参数
    public float portalTriggerRadius = 2.0f;
    public float portalAuxSendLevel = 0.0f;

    // 控制房间门传送行为的参数
    public bool portalTransmit = true;
    public bool portalMirror = false;

    // 创建一个AkRoomPortal对象
    private AkRoomPortal portal;

    void Start()
    {
        // 获取AkRoomPortal组件
        portal = GetComponent<AkRoomPortal>();

        // 设置房间门的触发器大小和辅助发送参数
        portal.PortalTrigger = portalTriggerRadius;
        portal.PortalAuxSendParams.level = portalAuxSendLevel;

        // 控制房间门的传送行为
        portal.PortalTransmit = portalTransmit;
        portal.PortalMirror = portalMirror;

        // 激活房间门
        portal.SetActive(true);
    }
}
