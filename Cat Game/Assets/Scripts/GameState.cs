using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameState : MonoBehaviour {
    public int num_of_cats;
	private float timeLeft;
	public int GameMode;
	public float TempNUM = 3;
	public bool inPlay;
	public static GameState instance;
	public int RightBoundary;
	public int LeftBoundary;
	public float transitionDuration = 5f;
	// Use this for initialization
	public static GameState Instance
	{
		get
		{ 
			return instance;
		}
	}
	void Awake()
	{
		if (instance==null) {
			instance=this;
		} else if(instance!=this) {
			Destroy (gameObject);
		}DontDestroyOnLoad (gameObject);

		GameMode = 0;
		}
	void Start () {
        num_of_cats = 0;
		timeLeft = TempNUM;
		inPlay = true;
	}
	
	// Update is called once per frame
	void Update () {
        num_of_cats = GameObject.FindGameObjectsWithTag("Cat").Length;
		if (timeLeft > 0 && GameMode == 0) {
			timeLeft -= Time.deltaTime;
		}
			if (timeLeft < 0)
        {
			inPlay=false;
			CamPan ();
	//		GameMode=1;
	//		timeLeft=TempNUM;
	//		Application.LoadLevel("EndGame");
		}



	}

    void OnGUI()
    {
		// GameMode 0 is main gameplay screen
		if (GameMode == 0) {
			GUIStyle style = new GUIStyle (GUI.skin.GetStyle ("label"));
			style.fontSize = 30;
			GUI.color = Color.black;
			GUI.Label (new Rect (25, 25, Screen.width / 2, Screen.height / 2), "Total: " + num_of_cats, style);
			GUI.Label (new Rect (25, 60, Screen.width / 2, Screen.height / 2), "Visible: " + num_of_cats, style);
			GUI.Label (new Rect (25, 100, Screen.width / 2, Screen.height / 2), "Time: " + (int)timeLeft, style);
		}

		// GameMode 1 is Score screen 
		if (GameMode == 1) {
			GUIStyle style2 = new GUIStyle (GUI.skin.GetStyle ("label"));
			style2.fontSize = 40;
			GUI.color = Color.black;
			GUI.Label (new Rect (25, 25, Screen.width / 2, Screen.height / 2), "You have hidden : " + num_of_cats + " cats!", style2);
		}
	}
	public void LoadGameLevel()
	{
		GameMode = 0;
		Application.LoadLevel ("Main Game Screen");
	}

	public void CamPan()
	{
		Vector3 minusVector = new Vector3 (.01f, 0, 0);
		Vector3 newPosition = new Vector3(RightBoundary,0,-10);
		Vector3 leftPosition = new Vector3(LeftBoundary,0,-10);
		Camera.main.transform.position = newPosition;
		float t = 0.0f;
		while (t < 1.0f) {
			t += Time.deltaTime;
			Camera.main.transform.position = Vector3.Lerp(newPosition,leftPosition,t);
		}

	}
}
