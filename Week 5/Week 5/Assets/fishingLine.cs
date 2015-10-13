using UnityEngine;
using System.Collections;

public class fishingLine : MonoBehaviour {
		
		LineRenderer line;
		private GameObject length;
		
		
		// Use this for initialization
		void Start () {
			
			length = GameObject.Find ("Length");
			
		}
		
		// Update is called once per frame
		void Update () {
			line = transform.GetComponent<LineRenderer> ();
			line.SetVertexCount (2);
			line.SetPosition (0, gameObject.transform.position);
			line.SetPosition (1, length.transform.position);
			
		}
	}