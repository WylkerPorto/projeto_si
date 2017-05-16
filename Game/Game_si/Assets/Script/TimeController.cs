using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour {
    public float tempo;
    Text text;
	public ScoresController meuScore;
    
    void Start ()
    {
        text = GetComponent<Text>();
        tempo = 99f;
    }
	
	void Update () {
        tempo -= Time.deltaTime;
        text.text = "Time : " + (int)tempo;
		if(tempo <= 0){
			PlayerPrefs.SetInt ("Score", meuScore.GetScore());
			SceneManager.LoadScene ("Score", LoadSceneMode.Single);
		}
    }
}
