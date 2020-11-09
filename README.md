# project_package_tests
A test of a project accessing tests inside a package.
This repository 

## Run the upm-ci commands
```bash
# Pack the package (and also isolate the tests inside the package)
upm-ci package pack --package-path com.unity.dummypackage
# Run the package tests (works: look out for a test called PackageTest)
upm-ci package test --package-path com.unity.dummypackage --unity-version C:\UNITY\2019.4.12f1\Editor
# Run the project tests (fails because the project cannot see the isolated tests from the pack step)
upm-ci project test --project-path dummyproject --type project-tests --unity-version C:\UNITY\2019.4.12f1\Editor
```

The last call will fail with the following error:
```bash
Running C:\UNITY\2019.4.12f1\Editor\Unity.exe
        arguments: -projectPath C:\Users\BRUNO~1.ANG\AppData\Local\Temp\tmp-21716jeHpnuwwt5e6\dummyproject -batchmode -logFile C:\DEV\project_package_tests\upm-ci~\test-results\dummyproject\playmode\dummyproject\UnityLog.txt -testPlatform playmode -testResults C:\DEV\project_package_tests\upm-ci~\test-results\dummyproject\playmode\dummyproject\TestResults.xml -deviceLogs C:\DEV\project_package_tests\upm-ci~\test-results\dummyproject\playmode\dummyproject -testSettingsFile C:\DEV\project_package_tests\upm-ci~\test-results\dummyproject\playmode\dummyproject\TestSettings.json -forgetProjectPath -automated "-forceFullStacktrace Assert" -api-profile NET_Standard_2_0 -crash-report-folder C:\DEV\project_package_tests\upm-ci~\test-results\dummyproject\playmode\dummyproject\CrashArtifacts -runTests -automated -accept-apiupdate -enablePackageManagerTraces
        id: 16360
        logs:
                C:\DEV\project_package_tests\upm-ci~\test-results\dummyproject\playmode\dummyproject\UnityLog.txt

LogEntry
        severity: Error
        message: An error occurred while resolving packages:
  Package com.unity.dummypackage@file:C:\DEV\project_package_tests\upm-ci~\packages\com.unity.dummypackage-0.0.1.tgz has invalid dependencies or related test packages:
    com.unity.dummypackage.tests (related package): Package [com.unity.dummypackage.tests@0.0.1] cannot be found

A re-import of the project may be required to fix the issue or a manual modification of C:/Users/BRUNO~1.ANG/AppData/Local/Temp/tmp-21716jeHpnuwwt5e6/dummyproject/Packages/manifest.json file.
```

Note: you can also pass the Editor.exe's folder to the `--unity-version argument` to avoid having to download Unity.