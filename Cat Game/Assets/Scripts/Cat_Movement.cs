using UnityEngine;
using System.Collections;

public class Cat_Movement : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;
    public float speed = 1.0f;
    public bool hidden;
    public const float hide_time = 10.0F;
    private float current_hide_time = 0;
    string direction;
    float walkTime;
    public bool draggable;
    Vector3 location = new Vector3(1, 0, 0);

    // Use this for initialization
    void Start () {
        walkTime = Random.Range(5.0F, 10.0F) ; //  How long will the cat walk in this direction;
        hidden = false;

    }
	

	// Update is called once per frame
	void Update () {

        if (!hidden)
        {
            move_cat();
        }
        else {
            current_hide_time -= Time.deltaTime;
        }

    }

    void OnTriggerEnter2D(Collider2D Furniture)
    {
        Debug.Log("testing!");
        if (Input.GetMouseButtonDown(0) )
        {
            if (Furniture.GetComponent<FurnitureObject>().addCat(hide_time))
            {
                hidden = true;
                gameObject.SetActive(false);
                current_hide_time -= hide_time;
            }
        }
    }

    void move_cat()
    {
        walkTime -= Time.deltaTime;
        if (walkTime <= 0) { location = flipDirection(location); }
        transform.position += location * speed * Time.deltaTime;
    }

    Vector3 flipDirection(Vector3 originalDir)
    {
        walkTime = Random.Range(5.0F, 10.0F);
        transform.Rotate(0, 180, 0, Space.Self);
        return new Vector3(-1 * originalDir.x, 0, 0); 
    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
        offset = this.gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    
    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }

}

