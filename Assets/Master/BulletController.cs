using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public float angle;
	public float speed;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 3);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position =  new Vector3(transform.position.x + Mathf.Cos(-(angle-90) * Mathf.Deg2Rad) * speed,
		transform.position.y, transform.position.z + Mathf.Sin(-(angle-90) * Mathf.Deg2Rad) * speed);
	}
}
