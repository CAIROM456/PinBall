using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public static int Score;
	private GameObject ScoreText;
	// Start is called before the first frame update
	void Start()
	{
		this.ScoreText = GameObject.Find("ScoreText");
	}
	// Update is called once per frame
	void Update()
	{
		this.ScoreText.GetComponent<Text> ().text = $"{Score.ToString("D9")}";
	}
}
