using UnityEditor;
using UnityEngine;

public class BuildScript
{
    public static void PerformBuild()
    {
        // 빌드할 씬 목록 (본인 프로젝트의 씬 경로로 수정하세요)
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };

        // 빌드 옵션 설정 (저장 경로와 타겟)
        BuildPipeline.BuildPlayer(scenes, "Builds/Windows/TestBuild.exe",
            BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
}
