using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Articles : MonoBehaviour {
	public Image target;
	public Sprite[] imgs = new Sprite[9];
	void Start()
	{
		int sn = PlayerPrefs.GetInt("stage_num");
		target.sprite = imgs[sn + 1];
	}
}
