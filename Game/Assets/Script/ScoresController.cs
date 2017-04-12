using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoresController : MonoBehaviour {
    private int score;
    Text text;

	// Use this for initialization
	void Awake () {
        text = GetComponent<Text>();
        text.text = score.ToString("000");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AumentaScore(int valorDeAumento)
    {
        score += valorDeAumento;
        text.text = score.ToString("000");
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetScore()
    {
        score = 0;
        text.text = score.ToString("000");
    }
}
