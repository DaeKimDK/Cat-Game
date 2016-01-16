using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
    int num_of_cats;
    float timeLeft = 30;
	// Use this for initialization
	void Start () {
        num_of_cats = 0;
	}
	
	// Update is called once per frame
	void Update () {
        num_of_cats = GameObject.FindGameObjectsWithTag("Cat").Length;
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 30;
        }
	}

    void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.GetStyle("label"));
        style.fontSize = 30;
        GUI.color = Color.black;
        GUI.Label(new Rect(25,25, Screen.width / 2, Screen.height / 2), "Total: " + num_of_cats, style);
        GUI.Label(new Rect(25, 60, Screen.width / 2, Screen.height / 2), "Visible: " + num_of_cats, style);
        GUI.Label(new Rect(1200, 25, Screen.width / 2, Screen.height / 2), "Time: " + timeLeft, style);
    }
}
