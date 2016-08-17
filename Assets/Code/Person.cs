using UnityEngine;
using System.Collections;
using EggToolkit;

public class Person : MonoBehaviour {

	// Use this for initialization
	void Start () {
		XmlToEgg<PersonClass>.SetXmlPath ("./Assets/Unity3D_XMLToEgg/xml-to-egg-test/Test.xml");
//		PersonClass per = XmlToEgg<PersonClass>.ToEgg ();
//		Debug.Log ("per_name:"+per.name);
//		Debug.Log ("per_age:"+per.age);
//		Debug.Log ("per_height:"+per.height);
//		Debug.Log ("per_weight:"+per.weight);
//		Debug.Log ("per_major:"+per.Major);
//		Debug.Log ("per_score:"+per.Score);

		PersonClass per = XmlToEgg<PersonClass>.ToPerson ();
		for(int i=0;i!=XmlToEgg<PersonClass>.Paranamelist.Count;i++)
		{
			string name=XmlToEgg<PersonClass>.Paranamelist[i];
			Debug.Log (name);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
