using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PosController : MonoBehaviour {
	public int score = 0;
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		score = PlayerPrefs.GetInt ("Score");
		pontos (score);
		print (score);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void SetScore (int i){
		score = i;
	}

	private void pontos (int i){
		text.text = i.ToString ("00000000");
	}
}
