using UnityEngine;
using System.Collections;

public class Cat_Movement : MonoBehaviour {

    public float speed = 1.0f;
    string direction;
    // Use this for initialization
    void Start () {
        direction = "left";
	}
	
	// Update is called once per frame
	void Update () {
        int movedir = direction == "left" ? 1 : -1;
        var move = new Vector3(movedir*1,0,0);
        transform.position += move * speed * Time.deltaTime;
    }
}
