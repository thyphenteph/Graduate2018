using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetra : MonoBehaviour {

	// Use this for initialization
	void Start() {
		Mesh mesh = new Mesh();

		mesh.vertices = new Vector3[] {
			new Vector3(0, 0, 0),
			new Vector3(1, 1, 0),
			new Vector3(-1, 1, 0)
		};

		mesh.triangles = new int[] {
			0,1,2
		};

		mesh.RecalculateNormals();
		var filter = GetComponent<MeshFilter>();
		filter.sharedMesh = mesh;
	}


	// Update is called once per frame
	void Update() {

	}
}
