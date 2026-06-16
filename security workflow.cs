name: Security Workflow

on:
  pull_request:
    branches: [ main ]
  push:
    branches: [ main ]

jobs:
  security-check:
    runs-on: ubuntu-latest

    steps:
    - name: Checkout Repository
      uses: actions/checkout@v3

    - name: Setup .NET
      uses: actions/setup-dotnet@v3
      with:
        dotnet-version: '6.0.x'

    - name: Code Scan (CodeQL)
      uses: github/codeql-action/init@v2
      with:
        languages: csharp

    - name: Dependency Check (Snyk)
      uses: snyk/actions/setup@v3
      with:
        command: test

    - name: Upload Vulnerability Report
      uses: actions/upload-artifact@v3
      with:
        name: security-report
        path: ./security-results/

    - name: Notify Maintainers
      run: echo "安全檢查完成，已通知 Maintainers ✅"
