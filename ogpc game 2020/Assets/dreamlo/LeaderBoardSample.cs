using UnityEngine;
using System.Collections.Generic;

public class LeaderBoardSample : MonoBehaviour {
	float startTime = 10.0f;
	float timeLeft = 0.0f;
	
	int totalScore;
	string playerName = "";
	string code = "";

	enum gameState {
		waiting,
		running,
		enterscore,
		leaderboard
	};
	
	gameState gs;
	
	
	// Reference to the dreamloLeaderboard prefab in the scene
	
	dreamloLeaderBoard dl;


	void Start () 
	{
		// get the reference here...
		this.dl = dreamloLeaderBoard.GetSceneDreamloLeaderboard();

		this.timeLeft = startTime;
		this.gs = gameState.waiting;
        totalScore =  (int) Stopwatch.timestart;
    }
	
	void Update () 
	{
		if (this.gs == gameState.running)
		{
            this.gs = gameState.enterscore;			
		}
	}
	
	void OnGUI()
	{
		var width200 = new GUILayoutOption[] {GUILayout.Width(200)};
		
		var width = 400;  // Make this wider to add more columns
		var height = 200;

		var r = new Rect((Screen.width / 2) - (width / 2), (Screen.height / 2) - (height), width, height);
		GUILayout.BeginArea(r, new GUIStyle("box"));
		
		GUILayout.BeginVertical();
		
		if (this.gs == gameState.waiting || this.gs == gameState.running)
		{
		
				this.gs = gameState.running;
			
			
		}
		
		
		
		if (this.gs == gameState.enterscore)
		{
			GUILayout.Label("Total Score: " + this.totalScore.ToString() + " Seconds");
			GUILayout.BeginHorizontal();
			GUILayout.Label("Your Name: ");
			this.playerName = GUILayout.TextField(this.playerName, width200);
			
			if (GUILayout.Button("Save Score"))
			{
				// add the score...
				if (dl.publicCode == "") Debug.LogError("You forgot to set the publicCode variable");
				if (dl.privateCode == "") Debug.LogError("You forgot to set the privateCode variable");

				dl.AddScore(this.playerName, totalScore);
				
				this.gs = gameState.leaderboard;
			}
			GUILayout.EndHorizontal();
		}
		
		if (this.gs == gameState.leaderboard)
		{
			GUILayout.Label("High Scores:");
			List<dreamloLeaderBoard.Score> scoreList = dl.ToListHighToLow();
			
			if (scoreList == null) 
			{
				GUILayout.Label("(loading...)");
			} 
			else 
			{
				int maxToDisplay = 20;
				int count = 0;
				foreach (dreamloLeaderBoard.Score currentScore in scoreList)
				{
					count++;
					GUILayout.BeginHorizontal();
					GUILayout.Label(currentScore.playerName, width200);
					GUILayout.Label(currentScore.score.ToString(), width200);
					GUILayout.EndHorizontal();

					if (count >= maxToDisplay) break;
				}
			}
		}
		
	}
	
	
}
