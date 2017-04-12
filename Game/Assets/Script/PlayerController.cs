using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rb;
	public Transform ground;

	private float axis;
	public float velocidade = 5;
	public float forcaPulo = 600;
	public bool isGrounded;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.gravityScale = 3;
	}
	
	// Update is called once per frame
	void Update () {
		isGrounded = Physics2D.Linecast (this.transform.position, ground.position, 1<<LayerMask.NameToLayer("Chao"));
		axis = Input.GetAxisRaw ("Horizontal");

		if (axis > 0) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
		} else if (axis < 0) {
			transform.Translate (Vector2.left * velocidade * Time.deltaTime);
		}

		if (Input.GetButtonDown ("Jump") && isGrounded) {
			rb.AddForce (transform.up * forcaPulo);
		}
	}
}
