using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining XP and detecting when we should level up.
    /// </summary>
    public class LevellingSystem : MonoBehaviour
	{
		public SimpleCharacterController charScript;

        private int currentXP;
		private int charLevel;
		private int levelThreshold;
	
		/// <summary>
		/// sets base stats and outputs a debug message to confirm stats
		/// </summary>
        private void Start()
        {
			//player level set to 1, current XP set to 0, and level up threshold set to 100 x player level
            charLevel = 1;
			currentXP = 0;
			levelThreshold = charLevel * 100;
			
			//debug message to show current level, xp, and level up threshold
			Debug.Log("Level: " + charLevel + " XP: " + currentXP + " Next Level Up: " + levelThreshold);
        }
		
		/// <summary>
		/// increases XP on a keypress, then checks if the level up threshold has been reached
		/// if it has, increases level, speed and jump height accordingly, with debug messages to confirm
		/// </summary>
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Return))
			{
				//adding a random amount of XP with a minimum of 50 and maximum of 100 when pressing Enter
				currentXP = currentXP + Random.Range(50, 100);
				//debug message showing updated XP
				
				Debug.Log("XP: " + currentXP);
				//checking if current XP has reached the level up threshold
				if (currentXP > levelThreshold)
				{
					//if true, level goes up by 1, currentXP is reset to 0, and levelThreshold is recalculated based on charLevel
					charLevel++;
					currentXP = 0;
					levelThreshold = charLevel * 100;

					//increases character speed and jump strength based on level
					//in this form of the script, player will have to be level 3 to have sufficient jump height to reach the level flag
					charScript.charSpeed += charLevel;
					charScript.charJump += charLevel;

					//debug message to show current charSpeed and charJump
					Debug.Log("Speed: " + charScript.charSpeed + " charJump: " + charScript.charJump);
				}

				//debug message to show current level, xp, and level up threshold
				Debug.Log("Level: " + charLevel + " XP: " + currentXP + " Next Level Up: " + levelThreshold);


			}
		}
	}
}
