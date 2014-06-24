using UnityEngine;
using System.Collections;

public class Vane : MonoBehaviour {
    private Mesh mesh;
    private 
	// Use this for initialization
	void Start () {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
	}
	
	// Update is called once per frame
	void Update () {
    }
}
