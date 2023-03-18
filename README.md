# WwiseToolkit

The WwiseToolkit consists of four main parts: Wwise SDK, Wwise Unity Integration, WAAPI and Unity Component.

* [中文版](./README_CN.md)
* [English](./README.md)

Wwise SDK, Wwise Unity Integration, WAAPI and Unity Component are four different tools, each with different functions and purposes. Here is what they are.

## 1. Wwise SDK (C++)

Wwise SDK is an audio engine software development kit for game developers that provides a set of features and APIs that enable developers to implement high-quality audio effects in their games.Wwise SDK includes rich audio processing and management features such as audio event creation, audio track mixing and transitions, application of audio effects, and more. By using the Wwise SDK, developers can easily manage all audio content in the game.

## 2. Wwise Unity Integration (C#)

Wwise Unity Integration is a Unity engine based plugin for integrating Wwise SDK into Unity projects. It provides a number of tools and features that enable developers to use all the features of the Wwise SDK in Unity.Wwise Unity Integration allows developers to create, edit and manage Wwise audio events in the Unity editor, as well as play, control and modify the parameters of Wwise audio events at runtime. By using Wwise Unity Integration, developers can easily integrate the Wwise audio engine into their Unity games and achieve high-quality audio effects.

The classes in Wwise Unity Integration are numerous and cover everything from audio event management to audio effect processing. Some of the most commonly used classes are listed below with a brief description of their functions and usage.

1. AkInitializer class: This class is used to initialise and connect the Wwise engine to the Unity engine, set global audio settings, preload audio events, etc.
2. AkBankManager class: This class is used to manage Wwise resource packages, you can load and unload resource packages, check the status of banks, etc.
3. AkSoundEngine class: this class is used to control the Wwise engine, you can play, pause, stop audio events, set audio parameters, etc.
4. AkEvent class: This class represents Wwise audio events and can be used to play audio events, set audio parameters, etc. by calling the Play() method.
5. AkGameObj: This class represents the game object of the Wwise sound source and provides management and control operations on the game object.
6. AkAudioListener class: This class represents the Wwise listener and allows you to add multiple listeners to the scene and to position the 3D sound by selecting different listeners.
7. AkAudioSource class: This class represents a Wwise audio source that allows you to add multiple audio sources to the scene and bind them to an AkEvent to control audio playback.
8. AkRoomPortal class: This class represents Wwise room doors and can be used to pass sound between rooms by adding them to the scene.
9. AkState and AkSwitch classes: these two classes are used to manage Wwise states and switches, which can be used to implement dynamic changes to audio events.
10. AkEnvironment class: this class represents the Wwise environment and can be used to simulate different sound processing, such as reverb, EQ, etc. by selecting different environments.
11. AkAuxSendArray and AkAuxSendValue classes: these two classes are used to manage the Wwise reverb and delay effects, and can control the reverb and delay effects of audio events.

For different needs, different classes can be chosen to implement the required functionality. Overall, Wwise Unity Integration offers a very rich library of classes to meet the various audio needs of developers.

## 3. WAAPI

WAAPI (Wwise Authoring API) is a set of APIs for programmatically interacting with and managing Wwise projects.WAAPI can be used to automate the creation, management and export of audio content, as well as integration with third-party tools. By using WAAPI, developers can easily perform batch processing, automate processes, customize workflows, and more to increase productivity and reduce error rates. WAAPI can be used with the Wwise SDK and Wwise Unity Integration to more easily manage and control audio content in Wwise projects.

## 4. Unity Component

Component in Unity refers to the components in a game object, which are the basic units that implement the game logic and functionality. Each component has its own properties and methods through which the behavior of the game object is controlled.

In Unity, there are many commonly used components, including Transform, MeshRenderer, Collider, Rigidbody, and so on. Here are the roles and common properties of each of these components.

1. Transform component: Transform component controls the position, rotation and scaling of game objects. Commonly used properties are position, rotation and scale. 2.
2. MeshRenderer component: The MeshRenderer component is used to render the model of the game object and can set the properties of material and texture.
3. Collider component: Collider component is used to detect the collision of game objects, including BoxCollider, SphereCollider, CapsuleCollider, etc.
4. Rigidbody component: Rigidbody component is used to control the physical movement of the game object, you can set the mass, gravity and other properties.
5. AudioSource component: AudioSource component is used to play sound, you can set the volume, pitch and other properties.
6. Animator component: Animator component is used to control the animation of the game object, you can create an animation controller (Animator Controller) to manage the animation transition and trigger conditions of the game object.
7. ParticleSystem component: ParticleSystem component is used to create particle effects, you can set the particle shape, color, speed and other attributes, as well as through the script to control the life cycle of the particles.
8. Light component: Light component is used to create light source, you can set the type, color, intensity and other properties of the light source.
9. Camera component: Camera component is used to create the camera, you can control the camera position, rotation, perspective and other properties, as well as through the script to control the movement of the camera.
10. Canvas component: Canvas component is used to create UI interface, you can add buttons, text, images and other UI elements, and control their behavior and display state through scripts.

In addition to these common components, Unity has many other components, each with its own functions and properties, which can be combined to achieve complex game logic and effects.Components in Unity are very important, and mastering the use of these components will allow developers to create great games more efficiently.

In summary, the Wwise SDK, Wwise Unity Integration, WAAPI and Unity Component are four different tools, each with a different function and purpose. Integration is used to integrate the Wwise SDK into a Unity project in order to use all the features of the Wwise SDK in Unity; WAAPI is used to programmatically interact with and manage Wwise projects to increase productivity and reduce error rates. Developers can choose to use one or more of these tools depending on their actual needs.
