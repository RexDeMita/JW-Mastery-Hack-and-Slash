using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{ 
    Player[] _players;

    void Awake()
    {
        //array of players
        _players = FindObjectsOfType<Player>(); 
    }

    public void AddPlayerToGame(Controller controller)
    {
        //order the players by player number
        //find the first uninitialized player without a controller assigned to them
        //and then assign a controller to them
        var firstNonActivePlayer = _players
            .OrderBy(t => t.PlayerNumber)
            .FirstOrDefault(t => t.HasController == false);
        firstNonActivePlayer.InitializePlayer(controller);
    }
}

