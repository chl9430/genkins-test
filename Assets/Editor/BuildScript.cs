using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildScript
{
    public static void PerformBuild()
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);

        string[] scenes = { "Assets/Scenes/Playground.unity" }; // 실제 씬 경로로 수정하세요
        string buildPath = "Builds/Test.apk"; // 확장자를 .apk로 변경

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = scenes;
        buildPlayerOptions.locationPathName = buildPath;
        buildPlayerOptions.target = BuildTarget.Android; // 안드로이드 타겟 지정
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build Succeeded!");
        }
        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build Failed!");
            // 여기서 강제로 에러를 발생시켜서 젠킨스가 인지하게 함
            EditorApplication.Exit(1);
        }
    }
}
