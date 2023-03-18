// 在Unity中，组件（Component）是一种可以挂载到GameObject对象上的基本元素，
// 它们实现了游戏对象的各种行为和功能。以下是Unity中一些常见的组件：


// 1.Transform
// Transform组件控制游戏对象的位置、旋转和缩放。每个GameObject都必须有一个Transform组件，因为它定义了游戏对象的坐标空间。
// 获取游戏对象的Transform组件
Transform objTransform = gameObject.GetComponent<Transform>();
// 设置游戏对象的位置和旋转
objTransform.position = new Vector3(0, 0, 0);
objTransform.rotation = Quaternion.identity;
// 缩放游戏对象
objTransform.localScale = new Vector3(2, 2, 2);


// 2.Rigidbody
// Rigidbody组件控制游戏对象的物理行为，例如重力、弹性和碰撞检测。
// 通过将Rigidbody组件添加到游戏对象上，可以使游戏对象变成刚体，并模拟物理行为。
// 获取游戏对象的Rigidbody组件
Rigidbody objRigidbody = gameObject.GetComponent<Rigidbody>();
// 设置游戏对象的质量和重力
objRigidbody.mass = 10;
objRigidbody.useGravity = true;
// 给游戏对象施加一个力
objRigidbody.AddForce(new Vector3(0, 10, 0));


// 3.Collider
// Collider组件用于检测游戏对象之间的碰撞。
// 当两个游戏对象的Collider组件发生碰撞时，可以触发一些事件或操作，例如播放音效、减少生命值等等。
// 获取游戏对象的Collider组件
Collider objCollider = gameObject.GetComponent<Collider>();
// 设置Collider组件的属性
objCollider.isTrigger = true;
// 添加碰撞事件处理函数
void OnCollisionEnter(Collision collision) {
    Debug.Log("Collision with " + collision.gameObject.name);
}


// 4.MeshRenderer
// MeshRenderer组件用于渲染游戏对象的3D模型。它定义了模型的外观、颜色、材质等属性。
// 获取游戏对象的MeshRenderer组件
MeshRenderer objRenderer = gameObject.GetComponent<MeshRenderer>();
// 设置MeshRenderer组件的材质和颜色
objRenderer.material = new Material(Shader.Find("Diffuse"));
objRenderer.material.color = Color.red;
// 隐藏游戏对象
objRenderer.enabled = false;


// 5.AudioSource
// AudioSource组件用于播放游戏对象的音效。通过将AudioSource组件添加到游戏对象上，可以设置音效的音量、音调、循环等属性。
// 获取游戏对象的AudioSource组件
AudioSource objAudio = gameObject.GetComponent<AudioSource>();
// 设置AudioSource组件的音频文件
objAudio.clip = Resources.Load<AudioClip>("audio/music");
// 播放音频
objAudio.Play();


// 6.Camera
// Camera组件用于渲染游戏场景并生成最终的图像输出。通过将Camera组件添加到游戏对象上，可以创建不同类型的相机，例如主摄像机、辅助相机等。
// 获取游戏对象的Camera组件
Camera objCamera = gameObject.GetComponent<Camera>();
// 设置Camera组件的参数
objCamera.fieldOfView = 60;
objCamera.backgroundColor = Color.blue;
// 渲染场景
objCamera.Render();


// 7.Light
// Light组件用于添加光源到场景中，可以设置不同类型的光源，例如点光源、聚光灯、方向光等。
// 获取游戏对象的Light组件
Light objLight = gameObject.GetComponent<Light>();
// 设置Light组件的类型和参数
objLight.type = LightType.Point;
objLight.intensity = 2;
// 开启或关闭光源
objLight.enabled = true;


// 8.ParticleSystem
// ParticleSystem组件用于创建粒子效果，可以模拟不同类型的粒子，例如火、烟、水等。
// 获取游戏对象的ParticleSystem组件
ParticleSystem objParticle = gameObject.GetComponent<ParticleSystem>();
// 设置ParticleSystem组件的参数
objParticle.startSpeed = 5;
objParticle.startLifetime = 3;
// 播放粒子效果
objParticle.Play();


// 9.Canvas
// Canvas组件用于创建UI界面，可以添加不同类型的UI元素，例如文本、按钮、图像等。
// 获取游戏对象的Canvas组件
Canvas objCanvas = gameObject.GetComponent<Canvas>();
// 设置Canvas组件的属性
objCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
objCanvas.pixelPerfect = true;
// 添加UI元素
Text objText = objCanvas.gameObject.AddComponent<Text>();
objText.text = "Hello, World!";


// 10.Rigidbody2D
// Rigidbody2D组件用于控制2D物理行为，与Rigidbody组件类似，可以模拟重力、碰撞等效果。
// 获取游戏对象的Rigidbody2D组件
Rigidbody2D objRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
// 设置Rigidbody2D组件的属性
objRigidbody2D.gravityScale = 2;
objRigidbody2D.mass = 5;
// 给游戏对象施加一个力
objRigidbody2D.AddForce(new Vector2(10, 0));


// 11.Animator
// Animator组件用于控制游戏对象的动画播放，可以添加不同类型的动画状态，例如站立、走路、跑步等。
// 获取游戏对象的Animator组件
Animator objAnimator = gameObject.GetComponent<Animator>();
// 添加一个动画状态
AnimatorState state = objAnimator.runtimeAnimatorController.animationClips[0];
objAnimator.AddState(state, new AnimatorControllerParameter() {
    type = AnimatorControllerParameterType.Bool,
    name = state.name
});
// 播放动画
objAnimator.SetBool(state.name, true);


// 12.TrailRenderer
// TrailRenderer组件用于渲染游戏对象的拖尾效果，可以设置拖尾的长度、宽度等属性。
// 获取游戏对象的TrailRenderer组件
TrailRenderer objTrailRenderer = gameObject.GetComponent<TrailRenderer>();
// 设置TrailRenderer组件的属性
objTrailRenderer.time = 2;
objTrailRenderer.widthMultiplier = 0.5f;
// 启用拖尾效果
objTrailRenderer.enabled = true;


// 13.BoxCollider2D
// BoxCollider2D组件用于给游戏对象添加碰撞体，可以检测游戏对象之间的碰撞事件。
// 获取游戏对象的BoxCollider2D组件
BoxCollider2D objCollider = gameObject.GetComponent<BoxCollider2D>();
// 设置BoxCollider2D组件的属性
objCollider.isTrigger = true;
objCollider.size = new Vector2(1, 1);
// 添加一个碰撞事件监听器
void OnCollisionEnter2D(Collision2D collision) {
    Debug.Log("Collided with " + collision.gameObject.name);
}


// 14.CircleCollider2D
// CircleCollider2D组件用于给游戏对象添加圆形碰撞体，可以检测游戏对象之间的碰撞事件。
// 获取游戏对象的CircleCollider2D组件
CircleCollider2D objCollider = gameObject.GetComponent<CircleCollider2D>();
// 设置CircleCollider2D组件的属性
objCollider.isTrigger = true;
objCollider.radius = 1;
// 添加一个碰撞事件监听器
void OnTriggerEnter2D(Collider2D collider) {
    Debug.Log("Triggered by " + collider.gameObject.name);
}


// 15.VideoPlayer
// VideoPlayer组件用于播放游戏对象的视频，可以控制视频的播放速度、音量、循环等属性。
// 获取游戏对象的VideoPlayer组件
VideoPlayer objVideo = gameObject.GetComponent<VideoPlayer>();
// 设置VideoPlayer组件的属性
objVideo.source = VideoSource.Url;
objVideo.url = "https://example.com/video.mp4";
objVideo.isLooping = true;
// 播放视频
objVideo.Play();


// 16.Image
// Image组件用于在画布中添加图像元素，可以控制图像的颜色、透明度等属性。
// 获取游戏对象的Image组件
Image objImage = gameObject.GetComponent<Image>();
// 设置Image组件的属性
objImage.color = Color.red;
objImage.sprite = Resources.Load<Sprite>("images/myImage");


// 17.Text
// Text组件用于在画布中添加文本元素，可以控制文本的颜色、字体、大小等属性。
// 获取游戏对象的Text组件
Text objText = gameObject.GetComponent<Text>();
// 设置Text组件的属性
objText.text = "Hello World!";
objText.color = Color.blue;
objText.fontSize = 24;


// 18.Button
// Button组件用于在画布中添加按钮元素，可以添加事件监听器来响应按钮点击事件。
// 获取游戏对象的Button组件
Button objButton = gameObject.GetComponent<Button>();
// 添加一个按钮点击事件监听器
objButton.onClick.AddListener(OnButtonClick);
void OnButtonClick() {
    Debug.Log("Button clicked!");
}


// 19.InputField
// InputField组件用于在画布中添加文本输入框元素，可以获取用户输入的文本内容。
// 获取游戏对象的InputField组件
InputField objInput = gameObject.GetComponent<InputField>();
// 添加一个文本输入事件监听器
objInput.onEndEdit.AddListener(OnInputEndEdit);
void OnInputEndEdit(string inputText) {
    Debug.Log("Input text: " + inputText);
}


// 20.ScrollRect
// ScrollRect组件用于在画布中添加可滚动的区域，可以用来显示大量内容，例如聊天记录、道具列表等。
// 获取游戏对象的ScrollRect组件
ScrollRect objScrollRect = gameObject.GetComponent<ScrollRect>();
// 设置ScrollRect组件的属性
objScrollRect.content = myContent;
objScrollRect.horizontal = false;
objScrollRect.vertical = true;


// 21.Dropdown
// Dropdown组件用于在画布中添加下拉菜单元素，可以添加选项和事件监听器来响应用户选择。
// 获取游戏对象的Dropdown组件
Dropdown objDropdown = gameObject.GetComponent<Dropdown>();
// 添加选项
List<string> options = new List<string>();
options.Add("Option 1");
options.Add("Option 2");
objDropdown.AddOptions(options);
// 添加选项选择事件监听器
objDropdown.onValueChanged.AddListener(OnDropdownValueChanged);
void OnDropdownValueChanged(int index) {
    Debug.Log("Dropdown value changed: " + options[index]);
}


// 22.Toggle
// Toggle组件用于在画布中添加复选框元素，可以添加事件监听器来响应用户选择。
// 获取游戏对象的Toggle组件
Toggle objToggle = gameObject.GetComponent<Toggle>();
// 添加复选框选择事件监听器
objToggle.onValueChanged.AddListener(OnToggleValueChanged);
void OnToggleValueChanged(bool isOn) {
    Debug.Log("Toggle value changed: " + isOn);
}


// 23.Slider
// Slider组件用于在画布中添加滑动条元素，可以添加事件监听器来响应用户拖动。
// 获取游戏对象的Slider组件
Slider objSlider = gameObject.GetComponent<Slider>();
// 设置Slider组件的属性
objSlider.minValue = 0;
objSlider.maxValue = 100;
objSlider.value = 50;
// 添加滑动条拖动事件监听器
objSlider.onValueChanged.AddListener(OnSliderValueChanged);
void OnSliderValueChanged(float value) {
    Debug.Log("Slider value changed: " + value);
}


// 24.Scrollbar
// Scrollbar组件用于在画布中添加滚动条元素，可以添加事件监听器来响应用户拖动。
// 获取游戏对象的Scrollbar组件
Scrollbar objScrollbar = gameObject.GetComponent<Scrollbar>();
// 设置Scrollbar组件的属性
objScrollbar.direction = Scrollbar.Direction.BottomToTop;
objScrollbar.size = 0.5f;
// 添加滚动条拖动事件监听器
objScrollbar.onValueChanged.AddListener(OnScrollbarValueChanged);
void OnScrollbarValueChanged(float value) {
    Debug.Log("Scrollbar value changed: " + value);
}


// 25.Mask
// Mask组件用于在画布中添加遮罩元素，可以将某个区域的内容遮挡起来，只显示指定的部分。
// 获取游戏对象的Mask组件
Mask objMask = gameObject.GetComponent<Mask>();
// 设置Mask组件的属性
objMask.showMaskGraphic = true;


// 26.CanvasScaler
// CanvasScaler组件用于自适应画布大小，可以根据不同的屏幕分辨率和比例进行缩放。
// 获取游戏对象的CanvasScaler组件
CanvasScaler objCanvasScaler = gameObject.GetComponent<CanvasScaler>();
// 设置CanvasScaler组件的属性
objCanvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
objCanvasScaler.referenceResolution = new Vector2(1080, 1920);
objCanvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
objCanvasScaler.matchWidthOrHeight = 0.5f;


// 27.LayoutElement
// LayoutElement组件用于控制UI元素的布局，可以根据自身大小和约束条件进行自动布局。
// 获取游戏对象的LayoutElement组件
LayoutElement objLayoutElement = gameObject.GetComponent<LayoutElement>();
// 设置LayoutElement组件的属性
objLayoutElement.minWidth = 100;
objLayoutElement.minHeight = 50;
objLayoutElement.flexibleWidth = 1;
objLayoutElement.flexibleHeight = 1;


// 28.CanvasGroup
// CanvasGroup组件用于控制UI元素的可见性和交互性，可以设置不透明度和交互状态。
// 获取游戏对象的CanvasGroup组件
CanvasGroup objCanvasGroup = gameObject.GetComponent<CanvasGroup>();
// 设置CanvasGroup组件的属性
objCanvasGroup.alpha = 0.5f;
objCanvasGroup.interactable = false;
objCanvasGroup.blocksRaycasts = false;


// 29.NavMeshAgent
// NavMeshAgent组件用于控制游戏对象的导航行为，可以设置导航目标和行动速度等。
// 获取游戏对象的NavMeshAgent组件
NavMeshAgent objNavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
// 设置NavMeshAgent组件的属性
objNavMeshAgent.destination = targetPosition;
objNavMeshAgent.speed = 5;
objNavMeshAgent.stoppingDistance = 1;
// 开始导航
objNavMeshAgent.isStopped = false;


// 30.TrailRenderer
// TrailRenderer组件用于在游戏对象上绘制拖尾效果，可以设置拖尾的颜色、宽度和持续时间等。
// 获取游戏对象的TrailRenderer组件
TrailRenderer objTrailRenderer = gameObject.GetComponent<TrailRenderer>();
// 设置TrailRenderer组件的属性
objTrailRenderer.time = 2;
objTrailRenderer.startColor = Color.white;
objTrailRenderer.endColor = Color.black;
objTrailRenderer.startWidth = 0.5f;
objTrailRenderer.endWidth = 0.1f;
// 启用TrailRenderer组件
objTrailRenderer.enabled = true;


// 31.ConstantForce
// ConstantForce 组件用于为游戏对象添加常数力，可以通过该组件添加一个不变的力，如风力、水流等。
// 获取游戏对象的 ConstantForce 组件
ConstantForce objConstantForce = gameObject.GetComponent<ConstantForce>();
// 设置 ConstantForce 组件的属性
objConstantForce.force = new Vector3(0, 0, 10);


// 32.Joint
// Joint 组件用于连接两个游戏对象，可以通过该组件连接物体，如关节、轮子等。
// 获取游戏对象的 Joint 组件
Joint objJoint = gameObject.GetComponent<Joint>();
// 设置 Joint 组件的属性
objJoint.connectedBody = connectedGameObject.GetComponent<Rigidbody>();
objJoint.anchor = new Vector3(0, 0, 0);


// 33.HingeJoint
// HingeJoint 组件用于为游戏对象添加铰链关节，可以通过该组件将游戏对象连接成一个刚体系统，如门、闸门等。
// 获取游戏对象的 HingeJoint 组件
HingeJoint objHingeJoint = gameObject.GetComponent<HingeJoint>();
// 设置 HingeJoint 组件的属性
objHingeJoint.connectedBody = connectedGameObject.GetComponent<Rigidbody>();
objHingeJoint.anchor = new Vector3(0, 0, 0);
objHingeJoint.axis = new Vector3(0, 1, 0);


// 34.pringJoint
// SpringJoint 组件用于为游戏对象添加弹簧关节，可以通过该组件模拟弹性系统，如吊桥、悬挂系统等。
// 获取游戏对象的 SpringJoint 组件
SpringJoint objSpringJoint = gameObject.GetComponent<SpringJoint>();
// 设置 SpringJoint 组件的属性
objSpringJoint.connectedBody = connectedGameObject.GetComponent<Rigidbody>();
objSpringJoint.anchor = new Vector3(0, 0, 0);
objSpringJoint.spring = 10.0f;
objSpringJoint.damper = 0.5f;


// 35.GraphicRaycaster
// GraphicRaycaster 组件用于检测游戏对象上的图形是否被鼠标或触摸事件点击，可以通过该组件实现游戏对象的交互功能。
// 获取游戏对象的 GraphicRaycaster 组件
GraphicRaycaster objGraphicRaycaster = gameObject.GetComponent<GraphicRaycaster>();
// 设置 GraphicRaycaster 组件的属性
objGraphicRaycaster.ignoreReversedGraphics = true;
objGraphicRaycaster.blockingObjects = GraphicRaycasterBlockingObjects.None;


// 36.ScrollRect
// ScrollRect 组件用于为游戏对象添加可滚动的 UI 界面，可以通过该组件实现游戏对象的滚动、拖拽等功能。
// 获取游戏对象的 ScrollRect 组件
ScrollRect objScrollRect = gameObject.GetComponent<ScrollRect>();
// 设置 ScrollRect 组件的属性
objScrollRect.content = content;
objScrollRect.horizontal = true;
objScrollRect.vertical = false;
objScrollRect.horizontalScrollbar = scrollbar;
objScrollRect.scrollSensitivity = 1.0f;


// 37.EventSystem
// EventSystem是Unity中的一个特殊组件，用于处理用户输入和事件响应。
// /它负责从输入设备（如鼠标、键盘和触摸屏）接收输入事件，并将这些事件发送给合适的UI元素进行响应。
// EventSystem组件是Unity中的UI系统的基础，用于处理UI元素的事件响应。
// /每个场景中只能有一个EventSystem组件，该组件在启动时自动创建。
// 以下是EventSystem组件的一些重要属性：
// First Selected（默认选中的UI元素）：场景中第一个被选中的UI元素。这通常用于控制光标的初始位置。
// Send Navigation Events：是否发送导航事件，导航事件是指用户在UI中使用键盘或手柄进行导航时发送的事件。
// Pixel Drag Threshold：当用户拖动UI元素时，移动的像素阈值，超过此阈值时才被认为是有效的拖动。
// Default Input Module：用于处理输入事件的默认输入模块，例如Standalone Input Module或Touch Input Module。
public class InputHandler : MonoBehaviour, IPointerClickHandler, IDragHandler
{
    // 当用户单击UI元素时调用此方法
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked " + eventData.pointerCurrentRaycast.gameObject.name);
    }

    // 当用户拖动UI元素时调用此方法
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragged " + eventData.pointerCurrentRaycast.gameObject.name);
    }
}
// IPointerClickHandler和IDragHandler。这些接口允许我们接收用户输入事件的回调。
// 当用户单击UI元素时，OnPointerClick方法将被调用，并打印出所单击的UI元素的名称。
// 当用户拖动UI元素时，OnDrag方法将被调用，并打印出所拖动的UI元素的名称。
