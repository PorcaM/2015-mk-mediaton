using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClearInfo : MonoBehaviour {
	public Text count, time, score;
	public void set_info(){
		count.text = "3/4";
		time.text = "1:30";
		score.text = "1,000";
	}
	void Start()
	{
		set_info();
	}
}