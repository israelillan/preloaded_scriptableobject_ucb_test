// using System.Linq;
// #if UNITY_EDITOR
// using UnityEditor;
// using UnityEditor.Build;
// using UnityEditor.Build.Reporting;
// #endif
using UnityEngine;

namespace Scenes
{
    [DefaultExecutionOrder(-10000)]
    public class ScriptableObjectTest : ScriptableObject
// #if UNITY_EDITOR
//         , IPreprocessBuildWithReport
// #endif
    {
// #if UNITY_EDITOR      
//         public int callbackOrder { get { return 0; } }
//         public void OnPreprocessBuild(BuildReport report)
//         {
//             CheckCreated();
//         }
//         
//         const string path = "Assets/" + nameof(ScriptableObjectTest) + ".asset";
//         [InitializeOnLoadMethod]
//         static void CheckCreated()
//         {
//             var settings = AssetDatabase.LoadAssetAtPath<ScriptableObjectTest>(path);
//             if (settings == null)
//             {
//                 settings = CreateInstance<ScriptableObjectTest>();
//                 AssetDatabase.CreateAsset(settings, path);
//                 AssetDatabase.SaveAssets();
//             }
//
//             var preloadedAssets = PlayerSettings.GetPreloadedAssets();
//             if (!preloadedAssets.Contains(settings))
//             {
//                 PlayerSettings.SetPreloadedAssets(preloadedAssets.Where(i => i != null).Append(settings).ToArray());
//             }
//         }
// #endif
        public static ScriptableObjectTest instance { get; private set; }
        [SerializeField] public string testValue = "Default Value";

        void OnEnable()
        {
            instance = this;
        }
    }
}