using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MathewHartley
{
    /// <summary>
    /// This class holds functionality for scene transition and reloading this scene to restart the game.
    /// </summary>
    public class SceneLoader : MonoBehaviour
    {
		private string sceneOne = "Platformer (Basic Scene)";
		private string sceneTwo = "Platformer (The Pipeworks)";
		private string sceneActive;

        private void LoadScene()
        {
			//loads scene titled the string assigned to sceneOne
			SceneManager.LoadScene(sceneActive);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
			//sets sceneActive to sceneOne
			sceneActive = sceneTwo;
			//runs the LoadScene method above
			LoadScene();

            // TODO Loader Bonus 1: Modify your load scene method so that you can write any string or int level and it will load that. (Hint: Adding parameters to it might help!)

        }
    }
}
