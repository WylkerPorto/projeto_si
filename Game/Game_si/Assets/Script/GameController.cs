using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject coin;
	public float minx = -36;
	public float maxx = 36;
	public float miny = -15;
	public float maxy = 15;
	public float minz = 0;
	public float maxz = 0;
	public float lifeTime = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Random.Range (minx, maxx);
		float y = Random.Range (miny, maxy);
		float z = Random.Range (minz, maxz);

		lifeTime -= Time.deltaTime;
		if (lifeTime < 0) {
			Instantiate (coin, new Vector3 (x, y, z), Quaternion.Euler(0, 0, 0));
			lifeTime = 5;
		}
		
	}
}
