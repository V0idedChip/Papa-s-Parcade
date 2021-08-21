using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PipeScript[] Pipes;

    /// <summary>
    /// CheckIfComplete goes through the list of pipes and counts up how many are incorrect. If none are incorrect, then the game ends.
    /// </summary>
    public void CheckIfComplete()
    {
        int incorrect = 0;

        foreach(PipeScript pipe in Pipes)
        {
            if (!pipe.isPlaced)
            {
                incorrect++;
            }
        }

        if(incorrect > 0)
        {
            Debug.Log("There are " + incorrect + " pipes needing to be repaired.");
        }
        else
        {
            TheGameManager.instance.Win();
        }        
    }
}
