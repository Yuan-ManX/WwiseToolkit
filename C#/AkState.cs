// AkState类是Wwise Unity Integration中的一个类，代表了Wwise项目中的状态。
// 以下是该类的所有功能的详细解释，包括相关的C#类和函数以及相应的代码和注释。
// 功能：
// 1.设置状态：设置AkState对象的状态。
// 2.获取状态：获取AkState对象的状态。
// 3.触发状态：触发AkState对象的状态。
// 4.取消状态：取消AkState对象的状态。

using UnityEngine;


// AK.Wwise.State是Wwise Unity Integration中的一个类，代表了Wwise项目中的状态。
// WwiseState是一个公共的AK.Wwise.State类型变量，它代表了与此AkState对象关联的Wwise状态。
// SetState()函数设置AkState对象的状态。它首先检查WwiseState变量是否为null，如果不为null，则调用WwiseState.SetValue()函数。
// GetState()函数获取AkState对象的状态。它首先检查WwiseState变量是否为null，如果不为null，则调用WwiseState.GetValue()函数，并返回结果。
// TriggerState()函数触发AkState对象的状态。它首先检查WwiseState变量是否为null，如果不为null，则调用WwiseState.SetValue(true)函数。
// UntriggerState()函数取消AkState对象的状态。它首先检查WwiseState变量是否为null，如果不为null，则调用WwiseState.SetValue(false)函数。
public class AkState : MonoBehaviour
{
    [Header("Wwise")]
    public AK.Wwise.State WwiseState; // 与此AkState对象关联的Wwise状态

    // 设置状态
    public void SetState()
    {
        if (WwiseState != null)
        {
            WwiseState.SetValue();
        }
    }

    // 获取状态
    public object GetState()
    {
        if (WwiseState != null)
        {
            return WwiseState.GetValue();
        }
        return null;
    }

    // 触发状态
    public void TriggerState()
    {
        if (WwiseState != null)
        {
            WwiseState.SetValue(true);
        }
    }

    // 取消状态
    public void UntriggerState()
    {
        if (WwiseState != null)
        {
            WwiseState.SetValue(false);
        }
    }
}
