using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnCube : MonoBehaviour {

	public Slider cubeSlider;
	public GameObject cubeToSpawn;
	private string[] names = {"gjjgg","kkjoioj","gfhfhfh","asdfdsa","qwertyui","mmnnnm"};

	public void spawnACube(){
		int cubeNumber = Mathf.RoundToInt(cubeSlider.value);

		for(int count = 0; count < cubeNumber; count++){
			GameObject JustSpawnedCube = Instantiate(cubeToSpawn,Random.insideUnitSphere * 10f, Quaternion.identity) as GameObject;
			JustSpawnedCube.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * 100f);
			JustSpawnedCube.GetComponentInChildren<Text>().text = names[Random.Range(0,names.Length)];

		}
	}
}

