# project_package_tests
A test of a project accessing tests inside a package

## Run the upm-ci commands
```bash
upm-ci package pack --package-path com.unity.dummypackage
upm-ci package test --package-path com.unity.dummypackage --unity-version 2019.4
upm-ci project test --project-path dummyproject --type project-tests --unity-version 2019.4
```

Note: you can also pass the Editor.exe's folder to the `--unity-version argument` to avoid having to download Unity.