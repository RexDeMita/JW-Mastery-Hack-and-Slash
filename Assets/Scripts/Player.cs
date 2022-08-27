using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //we can set the player number in the editor
    [SerializeField] int playerNumber;

    Controller _controller;

    //this will return the value of controller and will tell us if this player has a controller or not
    public bool HasController { get { return _controller != null; } }

    //this property will return the private player number. nothing will be able to set this value outside of this class
    public int PlayerNumber { get { return playerNumber; } }

    public void InitializePlayer(Controller controller)
    {
        //this sets the field _controller to the value of the controller passed into this method as a parameter
        this._controller = controller; 
        
        //set the name of the player using a string format method
        gameObject.name = string.Format("Player {0} - {1}", playerNumber, controller.gameObject.name);


    }
}