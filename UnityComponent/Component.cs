// 1.Transform
// Transform组件控制游戏对象的位置、旋转和缩放。每个GameObject都必须有一个Transform组件，因为它定义了游戏对象的坐标空间。
// 获取游戏对象的Transform组件
Transform objTransform = gameObject.GetComponent<Transform>();
// 设置游戏对象的位置和旋转
objTransform.position = new Vector3(0, 0, 0);
objTransform.rotation = Quaternion.identity;
// 缩放游戏对象
objTransform.localScale = new Vector3(2, 2, 2);
