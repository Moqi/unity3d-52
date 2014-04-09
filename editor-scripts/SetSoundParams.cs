using UnityEditor;
using UnityEngine;
public class SetSoundParams : MonoBehaviour {
	
	[MenuItem ("Tools/Custom/Set sound params")]
	static void DoSetSoundParams()
	{
		var objects = Selection.objects;
		
		foreach(Object obj in objects) {
			string path = AssetDatabase.GetAssetPath(obj);
			AudioImporter audioImporter = AssetImporter.GetAtPath(path) as AudioImporter;

			if(audioImporter.threeD != false)
			{
				//add your sound settings here, more info -> https://docs.unity3d.com/Documentation/ScriptReference/AudioImporter.html
				audioImporter.threeD = false;

				//re-import assets after you are done changing settings - without this the changes will be discarded!
				AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate | ImportAssetOptions.Default);
			}
		}
	}
}