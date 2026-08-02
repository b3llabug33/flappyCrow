using UnityEditor;
using UnityEngine;

public class WebGLBuildScript
{
    public static void PerformBuild()
    {
        string[] scenes = { "Assets/flappycrow.unity" };
        string outputPath = "WebGLBuild";

        BuildPlayerOptions options = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = outputPath,
            target = BuildTarget.WebGL,
            options = BuildOptions.None
        };

        var report = BuildPipeline.BuildPlayer(options);
        Debug.Log("Build result: " + report.summary.result);

        if (report.summary.result != UnityEditor.Build.Reporting.BuildResult.Succeeded)
        {
            EditorApplication.Exit(1);
        }
    }
}
