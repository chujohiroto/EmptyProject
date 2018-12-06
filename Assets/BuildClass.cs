using UnityEditor;
using UnityEngine;

public class BuildClass
{
    public static void Build()
	{
		EditorBuildSettingsScene scene = new EditorBuildSettingsScene("Assets/Scenes/SampleScene.unity", true) ;

		EditorBuildSettingsScene[] scenes = new EditorBuildSettingsScene[1];
		scenes[0] = scene;
        // 実行
	    var builds = BuildPipeline.BuildPlayer(scenes,"/mnt/ramdisk/test",BuildTarget.StandaloneLinuxUniversal,BuildOptions.None);
    }
}