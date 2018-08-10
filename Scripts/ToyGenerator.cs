using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyGenerator : MonoBehaviour {
	[SerializeField] Transform toys;
	[SerializeField] GameObject target;
	[SerializeField] GameObject[] disturb;
	[SerializeField] int objectNum;
	[HideInInspector] public bool exist;
	Vector3 insArea;


	// Use this for initialization
	void Start() {
		insArea.x = transform.localScale.x / 2;
		insArea.y = 0;
		insArea.z = transform.localScale.z / 2;


		//目的刺激有無
		if (Random.Range(0.0f, 1.0f) >= 0.5) exist = true;
		else exist = false;
		

		//目的刺激生成
		Vector3 targetPos = new Vector3(
			Random.Range(-insArea.x, insArea.x),
			0.1f,
			Random.Range(-insArea.z, insArea.z))
			+ transform.position;
		Vector3 randEuler = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));

		if (exist) Instantiate(target, targetPos, Quaternion.Euler(randEuler), toys);


		//妨害刺激生成
		for (int i = 0; i < objectNum; i++) {
			Vector3 disturbPos = new Vector3(
				Random.Range(-insArea.x, insArea.x),
				0.1f,
				Random.Range(-insArea.z, insArea.z))
				+ transform.position;
			randEuler = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));

			int type = Random.Range(0, disturb.Length);

			Instantiate(disturb[type], disturbPos, Quaternion.Euler(randEuler), toys);
			
		}

	}

	// Update is called once per frame
	void Update() {

	}
}
