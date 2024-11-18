using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public Transform spawnPoint;
	public GameObject player;

	// Flags that control the state of the game
	private float elapsedTime = 0;
	private bool isRunning = false;
	private bool isFinished = false;

	// So that we can access the player's controller from this script
	private FPSController fpsController;
	void Start ()
	{
		//Tell Unity to allow character controllers to have their position set directly. This will enable our respawn to work
		Physics.autoSyncTransforms = true;

		// Finds the First Person Controller script on the Player
		fpsController = player.GetComponent<FPSController> ();
	
		// Disables controls at the start.
		fpsController.enabled = false;
	}


	//This resets to game back to the way it started
	private void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		isFinished = false;

		// Move the player to the spawn point, and allow it to move.
		PositionPlayer();
		fpsController.enabled = true;
	}


	// Update is called once per frame
	void Update ()
	{
        isGameOver = blue.isSolved && green.isSolved && red.isSolved &&  orange.isSolved;
		// Add time to the clock if the game is running
		if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}
	}


	//Runs when the player needs to be positioned back at the spawn point
	public void PositionPlayer()
	{
		player.transform.position = spawnPoint.position;
		player.transform.rotation = spawnPoint.rotation;
	}


	// Runs when the player enters the finish zone
	public void FinishedGame()
	{
		isRunning = false;
		isFinished = true;
		fpsController.enabled = false;
	}
	
	
	//This section creates the Graphical User Interface (GUI)
	void OnGUI() {
		
		if(!isRunning)
		{
			string message;

			if(isFinished)
			{
				message = "Click or Press Enter to Play Again";
			}
			else
			{
				message = "Click or Press Enter to Play";
			}

			//Define a new rectangle for the UI on the screen
			Rect startButton = new Rect(Screen.width/2 - 120, Screen.height/2, 240, 30);

			if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
			{
				//start the game if the user clicks to play
				StartGame ();
			}
		}
		
		// If the player finished the game, show the final time
		if(isFinished)
		{
			GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
			GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
		}
		else if(isRunning)
		{ 
			// If the game is running, show the current time
			GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
			GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
		}
        {

       if(isGameOver)

       {

           Rect rect = new Rect (Screen.width / 2 - 100, Screen.height /  2 - 50, 200, 75);

           GUI.Box (rect, "Game Over");

           Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height /  2 - 25, 60, 50);

           GUI.Label (rect2, "Good Job!");

         }

      }
	}

    public GoalScript blue, green, red, orange;

    private bool isGameOver = true;

}
