flowchart LR
    Dev[開發分支 feature/AiInstuctor VR XR Reality Screen ] --> Test[CI/CD 測試流程]
    Test --> Main[主分支 main]
    Main --> Release[建立 Release Tag vX.Y.Z]
    Release --> Deploy[WebGL 部署 GitHub Pages / Server]
    Deploy --> Notify[通知 Maintainers]
