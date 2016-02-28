using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {
	Animator animator;
	float flapForce = 3.5f;//gravity scale = 0.5
	bool collided=false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();

	}

	void FixedUpdate () {
		animator.SetFloat("vertical_velocity", this.GetComponent<Rigidbody2D>().velocity.y);

	}
	

	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown(KeyCode.Space)) {
				GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, flapForce);
			}

		if (Input.GetKeyDown(KeyCode.Q)) {
			Application.Quit();
		}
		//probar en android
		//Vector2 touch = Input.GetTouch(0).deltaPosition;
		//rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, flapForce*touch.y);
	
	}

	void OnCollisionEnter2D (Collision2D col) {
		Debug.Log("GAME OVER");
		collided=true;

	}

	public bool Collided {
		get {
			return collided;
		}
	}
}