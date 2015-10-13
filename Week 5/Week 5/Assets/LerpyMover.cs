using UnityEngine;
using System.Collections;

public class LerpyMover : MonoBehaviour {

	private Transform startPoint, endPoint;
	public float percentage;
	public float speed;
	private int direction;


	void Start () {
		startPoint = GameObject.Find ("startPoint").transform;
		endPoint = GameObject.Find ("endPoint").transform;
		direction = 1;
		//speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage);
		//transform.rotation = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(new Vector3(-90,-120,3)), percentage);
		transform.rotation = Quaternion.Lerp (Quaternion.identity, Quaternion.Euler (new Vector3 (0, 0, 190)), percentage);

		//gameObject.GetComponent<Renderer> ().material.color = Color.Lerp (Color.red, Color.cyan, percentage);

		speed = Mathf.Max (speed, .000001f);
		//if (speed == 0)
		//	speed = .000001f;
	
		percentage += Time.deltaTime * direction * speed;

		//keep percentage within range
		if ((percentage > 1) || (percentage < 0))  {
			direction = -direction;
			percentage = Mathf.Clamp (percentage, 0, 1);
		}

		//switch direction
	}
}
