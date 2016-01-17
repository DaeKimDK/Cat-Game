using UnityEngine;
using System.Collections;

public class CatSpawner : MonoBehaviour {
    public float spawnTimer;
    private float timer;
    public GameObject cats;
    public Transform spawnPoint;
    
	// Use this for initialization
	void Start () {
        timer = spawnTimer;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = spawnTimer;
            Instantiate(cats, spawnPoint.position, spawnPoint.rotation);
        }
	}
}
