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
flowchart LR
    User[用家] --> Eye[EyeTrackingManager 動眼控制]
    User --> Voice[VoiceCommandManager 語音指令]
    User --> Motion[MotionTrackingManager 體感數據]

    Eye --> Controller[ControllerManager 控制器]
    Voice --> Controller
    Motion --> Controller

    Controller --> FiveSense[五感模組]
    Controller --> AI[AI 建議系統]

    FiveSense --> Visual[視覺 VR 場景]
    FiveSense --> Audio[聽覺 語音合成 + LipSync]
    FiveSense --> Haptic[觸覺震動回饋]
    FiveSense --> Smell[嗅覺模組]
    FiveSense --> Taste[味覺模擬器]

    AI --> Feedback[智能提示回饋]

    Visual --> User
    Audio --> User
    Haptic --> User
    Smell --> User
    Taste --> User
    Feedback --> User

