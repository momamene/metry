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

        Vector2 cameraSize = new Vector2(FindObjectOfType<Camera>().orthographicSize * 1.5f,
                                         FindObjectOfType<Camera>().orthographicSize);
        if (cameraSize.x + renderer.bounds.size.x < transform.position.x) {
            transform.position += new Vector3(-cameraSize.x - renderer.bounds.size.x, 0, 0) * 2.0f;
        }
        else if (-cameraSize.x - renderer.bounds.size.x > transform.position.x) {
            transform.position += new Vector3(cameraSize.x + renderer.bounds.size.x, 0, 0) * 2.0f;
        }
        if (cameraSize.y + renderer.bounds.size.y < transform.position.y) {
            transform.position += new Vector3(0, -cameraSize.y - renderer.bounds.size.y, 0) * 2.0f;
        }
        else if (-cameraSize.y - renderer.bounds.size.y > transform.position.y) {
            transform.position += new Vector3(0, cameraSize.y + renderer.bounds.size.y, 0) * 2.0f;
        }
    }
}
