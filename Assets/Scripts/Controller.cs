using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //this class needs a way to reference different buttons for different moves
    //know what controller number is being used or is needed
    //know the in put strings
    
    //controller index 
    public int Index { get; private set; }
    public bool IsAssigned { get; set; }

    string attackButton;
    public bool attack;

    void Update()
    {
        //if the string is null or empty (if there is no attack button)
        if (!string.IsNullOrEmpty(attackButton))
        {
            //this assigns the value from the input to attack
            attack = Input.GetButton(attackButton);
        }
    }

    public void SetIndex(int index)
    {
        //Index is being assigned the value of index from the controller manager 
        Index = index;
        
        //set the attack button to "Attack" plus the index number
        attackButton = "Attack" + Index;
        
        //set the name of the object to the index number
        gameObject.name = "Controller" + Index;  
    }

    public bool AnyButtonDown()
    {
        return attack;
    }
}
