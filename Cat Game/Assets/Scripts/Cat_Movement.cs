using UnityEngine;
using System.Collections;

public class Cat_Movement : MonoBehaviour {

    public float speed = 1.0f;
    public bool hidden;
    public float hide_time = 10.0F;
    string direction;
    float walkTime;
    Vector3 location = new Vector3(1, 0, 0);

    // Use this for initialization
    void Start () {
        walkTime = Random.Range(5.0F, 10.0F) ; //  How long will the cat walk in this direction;
        hidden = true;

    }
	
	// Update is called once per frame
	void Update () {
        walkTime -= Time.deltaTime;
        if(walkTime <= 0){ location = flipDirection(location); }
        transform.position += location * speed * Time.deltaTime;
    }


    Vector3 flipDirection(Vector3 originalDir)
    {
        walkTime = Random.Range(5.0F, 10.0F);
        transform.Rotate(0, 180, 0, Space.Self);
        return new Vector3(-1 * originalDir.x, 0, 0); 
    }
}

