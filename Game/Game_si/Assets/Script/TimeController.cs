using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeController : MonoBehaviour {
    public float tempo;
    Text text;
    
    void Start ()
    {
        text = GetComponent<Text>();
        tempo = 99f;
    }
	
	void Update () {
        tempo -= Time.deltaTime;
        text.text = "Time : " + (int)tempo;
    }
}
