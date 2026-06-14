graph LR
    SystemInit --> ControllerManager

    ControllerManager --> EyeTrackingManager
    ControllerManager --> VoiceCommandManager
    ControllerManager --> AudioManager
    ControllerManager --> VisualManager
    ControllerManager --> HapticManager
    ControllerManager --> SmellManager
    ControllerManager --> TasteManager
    ControllerManager --> MotionTrackingManager

    EyeTrackingManager --> XR_API[OpenXR / Tobii SDK]
    VoiceCommandManager --> Speech_API[Azure Speech SDK]
    AudioManager --> TTS[TTS 引擎 / LipSync]
    VisualManager --> XR_Toolkit[Unity XR Toolkit]
    HapticManager --> VR_Controller[VR 控制器 API]
    SmellManager --> Smell_Device[外接嗅覺模組]
    TasteManager --> Taste_Device[味覺模擬器]
    MotionTrackingManager --> Skeleton_API[骨架追蹤 / 姿勢偵測]
