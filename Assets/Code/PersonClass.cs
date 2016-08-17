using UnityEngine;
using System.Collections;

public class PersonClass {
	//变量名与xml文件中的名称要相互一致
	public string name;
	public int age;
	public float height;
	public float weight;
	public string Major;
	public int Score;
	private int hht;

	public PersonClass(string _name,int _age,float _height,float _weight,string _Major,int _Score)
	{
		name = _name;
		age = _age;
		height = _height;
		weight = _weight;
		Major = _Major;
		Score = _Score;
	}
}
