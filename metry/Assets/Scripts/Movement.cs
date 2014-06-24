using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 delta = Vector3.zero;
        if (Input.GetKey(KeyCode.DownArrow)) {
            delta.y -= speed;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            delta.y += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            delta.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            delta.x += speed;
        }
        transform.position += delta;
        if (Const.ViewportSize.xMax + renderer.bounds.size.x < transform.position.x) {
            transform.position += new Vector3(Const.ViewportSize.xMin - renderer.bounds.size.x, 0, 0) * 2.0f;
        }
        else if (Const.ViewportSize.xMin - renderer.bounds.size.x > transform.position.x) {
            transform.position += new Vector3(Const.ViewportSize.xMax + renderer.bounds.size.x, 0, 0) * 2.0f;
        }
        if (Const.ViewportSize.yMax + renderer.bounds.size.y < transform.position.y) {
            transform.position += new Vector3(0, Const.ViewportSize.yMin - renderer.bounds.size.y, 0) * 2.0f;
        }
        else if (Const.ViewportSize.yMin - renderer.bounds.size.y > transform.position.y) {
            transform.position += new Vector3(0, Const.ViewportSize.yMax + renderer.bounds.size.y, 0) * 2.0f;
        }
    }
}
