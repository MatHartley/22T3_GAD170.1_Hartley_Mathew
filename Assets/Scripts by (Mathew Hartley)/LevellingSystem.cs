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
        private int currentXP;
		private int charLevel;
		private int levelThreshold;
	
        private void Start()
        {
			//player level set to 1, current XP set to 0, and level up threshold set to 100 x player level
            charLevel = 1;
			currentXP = 0;
			levelThreshold = charLevel * 100;
			
			//debug message to show current level, xp, and level up threshold
			Debug.Log("Level: " + charLevel + " XP: " + currentXP + " Next Level Up: " + levelThreshold);

			//adding a random amount of XP with a minimum of 50 and maximum of 100
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
			}
			//debug message to show current level, xp, and level up threshold
			Debug.Log("Level: " + charLevel + " XP: " + currentXP + " Next Level Up: " + levelThreshold);

            // TODO XP Bonus: Adjust our character's stats ("runSpeed" and/or "jumpStrength") based on their level. (Hint: You'll need a reference to the SimpleCharacterController script!)

        }
    }
}
