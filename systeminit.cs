using UnityEngine;

public class SystemInit : MonoBehaviour
{
    public ControllerManager controller;

    void Start()
    {
        Debug.Log("系統初始化開始...");

        // 初始化動眼模組
        InitEyeTracking();

        // 初始化語音模組
        InitVoiceCommand();

        // 初始化五感模組
        InitFiveSenseModules();

        // 初始化體感模組
        InitMotionTracking();

        Debug.Log("系統初始化完成 ✅");
    }

    private void InitEyeTracking()
    {
        if (controller.eyeTracking != null)
        {
            Debug.Log("動眼模組已啟動");
        }
    }

    private void InitVoiceCommand()
    {
        if (controller.voiceCommand != null)
        {
            controller.voiceCommand.ProcessVoiceCommand("開始");
            Debug.Log("語音模組已啟動");
        }
    }

    private void InitFiveSenseModules()
    {
        if (controller.audioManager != null)
            controller.audioManager.PlayVoice("五感模組已啟動");

        if (controller.hapticManager != null)
            controller.hapticManager.TriggerHapticFeedback(0.3f, 1.0f);

        if (controller.smellManager != null)
            controller.smellManager.TriggerSmell("清新空氣");

        if (controller.tasteManager != null)
            controller.tasteManager.TriggerTaste("中性味覺");

        Debug.Log("五感模組已啟動");
    }

    private void InitMotionTracking()
    {
        if (controller.motionTracking != null)
        {
            controller.motionTracking.UpdateMotion();
            Debug.Log("體感模組已啟動");
        }
    }
}
