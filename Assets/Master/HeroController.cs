using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ThrowProjectile();
	}

	void ThrowProjectile(){
		if(Input.GetMouseButtonDown(0)){
			GameObject bulletObject = Instantiate(bulletPrefab);
			
			BulletController bullet = bulletObject.GetComponent<BulletController>();

			Debug.Log("LocalEulerAngles y: " + transform.localEulerAngles.y);
			Debug.Log("\nRotation Y: " + transform.rotation.y);

			bullet.angle = transform.localEulerAngles.y;

			bulletObject.transform.position = new Vector3(transform.position.x + Mathf.Cos(-(bullet.angle-90) * Mathf.Deg2Rad) * 3,
			transform.position.y, transform.position.z + Mathf.Sin(-(bullet.angle-90) * Mathf.Deg2Rad) * 3);
		}
	}
}
