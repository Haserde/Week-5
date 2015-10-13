using UnityEngine;
using System.Collections;

public class lengthScript : MonoBehaviour {

	public float speed;
	private new Vector3 startPos;
	public GameObject ending;
	public GameObject star;
	public GameObject capsule;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		} else { 
			transform.position = capsule.transform.position;
		}

	}

	void OnTriggerEnter (Collider other){
		star.GetComponent<LerpyMover> ().enabled = false;
		star.transform.parent = ending.transform;
		Debug.Log ("hit detected");
}
}