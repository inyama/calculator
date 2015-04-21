using UnityEngine;
using System.Collections;
using UnityEditor;


public class LoadController : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{

		var defaultFieldPrefab =
			AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Ship.prefab", typeof (GameObject)) as
				GameObject;
		for (int i=0; i<10; i++) {
			
			Quaternion q = Quaternion.identity;
			var Tile =
				Instantiate(defaultFieldPrefab, new Vector3(i*10,
				                                                     0, 0),
				            q) as
					GameObject;
					
				}
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
