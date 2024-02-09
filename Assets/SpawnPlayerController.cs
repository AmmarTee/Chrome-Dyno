using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerController : MonoBehaviour
{
   public GameObject player;
    void Start()
    {
        if (player == null)
        {
            Debug.LogError($"{player} is Missing Please assign the correct variable in the Inspector");
            return;

        }
        else
        {
            Instantiate(player,transform.position,transform.rotation);
            Debug.Log("Player has successfully Spawn at the Location");
        }
    }

   
}
