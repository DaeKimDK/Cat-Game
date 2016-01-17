using UnityEngine;
using System.Collections;

public class FurnitureObject : MonoBehaviour {

    public int hideable_cats = 3;
    int cats_hidden = 0;
    float[] cats;
    Animator anim;
    GameObject SFX;
    // Use this for initialization
    void Start () {
        cats = new float[hideable_cats];
        SFX = GameObject.FindWithTag("SFX");
        SFX.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        for(int i = 0; i < hideable_cats; i++)
        {
            cats[i] -= Time.deltaTime;
            if (cats[0] < 3.0F)
            {
                Animator anim = SFX.GetComponent<Animator>();
                anim.StartPlayback();
                SFX.gameObject.SetActive(true);
                if (cats[i] <= 0.0F) {
                    anim.StopPlayback();
                    removeCat(i);
                    continue; }
            }
        }
	}

    void OnTriggerEnter2D(Collider2D cat){ addCat(cat.GetComponent<Cat_Movement>().hide_time);}
    public void addCat(float catTime){ cats[cats_hidden++] = catTime; }
    void removeCat(int index) { cats[index] = 0; cats_hidden--; }
}
