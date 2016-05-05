using UnityEngine;
using System.Collections;

public class ButtonAction : MonoBehaviour {
	public void ArticleLink(string link)
	{
		Application.OpenURL(link);
	}
	public void load(string level)
	{
		Application.LoadLevel(level);
	}
	public void load_stage(int stage_num)
	{
		PlayerPrefs.SetInt("stage_num", stage_num);
		Application.LoadLevel("ingame");
	}
}
