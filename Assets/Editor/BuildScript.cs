using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildScript
{
    // PC 빌드용
    public static void PerformPCBuild()
    {
        BuildPlayerOptions opt = new BuildPlayerOptions();
        opt.scenes = new[] { "Assets/Scenes/Playground.unity" };
        opt.locationPathName = "Builds/PC/Test.exe";
        opt.target = BuildTarget.StandaloneWindows64;
        BuildPipeline.BuildPlayer(opt);
    }

    // Android 빌드용
    public static void PerformAndroidBuild()
    {
        BuildPlayerOptions opt = new BuildPlayerOptions();
        opt.scenes = new[] { "Assets/Scenes/Playground.unity" };
        opt.locationPathName = "Builds/Android/Test.apk";
        opt.target = BuildTarget.Android;
        BuildPipeline.BuildPlayer(opt);
    }
}
