using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class GameManager : NetworkBehaviour
{
    private bool gameGoing;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Server]
    public void StartGame()
    {
        gameGoing = true;

    }
    
    
    [Server]
    private void GiveRole()
    {
        if (gameGoing == true)
        {

        }
    }
}
