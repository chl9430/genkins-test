using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildScript
{
    public static void PerformBuild()
    {
        string[] scenes = { "Assets/Scenes/Playground.unity" }; // 실제 씬 경로로 수정하세요
        string buildPath = "Builds/MyGame.apk"; // 확장자를 .apk로 변경

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = scenes;
        buildPlayerOptions.locationPathName = buildPath;
        buildPlayerOptions.target = BuildTarget.Android; // 안드로이드 타겟 지정
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        // ... 생략 (나머지 로그 출력 부분)
    }
}
