using UnityEngine;
using System.Collections;

public class FurnitureObject : MonoBehaviour {

    public int hideable_cats = 3;
    int cats_hidden = 0;
    float[] cats;
    Animator anim;
    // Use this for initialization
    void Start () {
        cats = new float[hideable_cats];
        anim = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        for(int i = 0; i < hideable_cats; i++)
        {
            cats[i] -= Time.deltaTime;
            if (cats[i] < 3.0F)
            {

                if (cats[i] <= 0.0F) {
                    anim.Stop();
                    removeCat(i);
                    continue; }
                anim.Play("Furniture_Animation");
            }
        }
	
	}
    void addCat(int catTime){ cats[cats_hidden++] = catTime; }
    void removeCat(int index) { cats[index] = 0; cats_hidden--; }
}
