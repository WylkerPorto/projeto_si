using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	public float death = 5;
	private float lifeTime;

	// Use this for initialization
	void Start () {
		lifeTime = death;
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime -= Time.deltaTime;
		if (lifeTime < 0) {
			Destroy (this.gameObject);
			lifeTime = death;
		}
	}

	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Finish") {
			Destroy (this.gameObject);
		}
	}
}
