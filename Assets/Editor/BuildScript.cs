using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildScript
{
    public static void PerformBuild()
    {
        // 씬 경로가 실제 프로젝트와 일치해야 합니다! (예: Scenes/SampleScene)
        string[] scenes = { "Assets/Scenes/Playground.unity" };
        string buildPath = "Builds/Test.apk";

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = scenes;
        buildPlayerOptions.locationPathName = buildPath;
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build Succeeded!");
        }
        else
        {
            Debug.LogError("Build Failed!");
            EditorApplication.Exit(1); // 젠킨스에 실패 알림
        }
    }
}
