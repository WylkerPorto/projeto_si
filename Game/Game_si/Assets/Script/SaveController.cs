using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SaveController : MonoBehaviour {

	public Text Score = null;
	public InputField NomeField = null;
	public Transform Button = null;
	private string url = "http://localhost/s7/SI/projeto_si/Game/Game_si/Assets/Script/Login.php";
	public AudioSource sWin;

	// Use this for initialization
	void Start () {
		sWin.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Gravar(){
		StartCoroutine (ToWWW());
	}

	private IEnumerator ToWWW(){
		string Nome = NomeField.text;
		string Pontos = Score.text;
		WWW www = new WWW (url + "?Nome=" + Nome + "&Pontos=" + Pontos);
		yield return www;
		//print (www.text);
		if(www.text == "1")
			Button.GetComponent<Button>().interactable = false;
	}
}
