using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Main : MonoBehaviour {

	public GameObject verticalWall;
	public GameObject buttomWall;
	public GameObject[] parts; 
	private List<GameObject> waitDeleted = new List<GameObject>();

	// Use this for initialization
	void Start () {
		//float Distance = Camera.main.orthographicSize * Camera.main.aspect * 1f;
		//GameObject leftWall = Instantiate(verticalWall) as GameObject;
		//leftWall.transform.position = new Vector3 (-Distance,0,0);
		//GameObject rightWall = Instantiate(verticalWall) as GameObject;
		//rightWall.transform.position = new Vector3 (Distance,0,0);
		float length = Camera.main.orthographicSize;
		GameObject bWall = Instantiate(buttomWall) as GameObject;
		bWall.transform.position = new Vector3 (0,-length,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startTest(){
		foreach(GameObject go in waitDeleted ){
			Destroy(go);
		}
		waitDeleted.Clear ();
		List<GameObject> l = new List<GameObject>(parts);
		while(l.Count > 0){
			int idx = Random.Range(0,l.Count);
			GameObject go = Instantiate(l[idx]) as GameObject;
			createPart(go);
			l.RemoveAt(idx);
			waitDeleted.Add(go);
		}
	}

	private void createPart(GameObject go){
		float Distance = Camera.main.orthographicSize * Camera.main.aspect ;
		float x = Random.Range(0,Distance*2f) - Distance;
		float length = Camera.main.orthographicSize;
		length += Random.Range(0,length*20);
		go.transform.position = new Vector3 (x,length,0);
	}
}
