using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
    int num_of_cats;
	// Use this for initialization
	void Start () {
        num_of_cats = 0;
	}
	
	// Update is called once per frame
	void Update () {
        num_of_cats = GameObject.FindGameObjectsWithTag("Cat").Length;
	}

    void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.GetStyle("label"));
        style.fontSize = 30;
        GUI.color = Color.black;
        GUI.Label(new Rect(30,30, Screen.width / 2, Screen.height / 2), num_of_cats.ToString(), style);
    }
}
