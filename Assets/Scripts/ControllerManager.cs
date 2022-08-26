using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{
    List<Controller> _controllers;

    void Awake()
    {
        //find and assign an index to each controller
        _controllers = FindObjectsOfType<Controller>().ToList();

        int index = 1;
        foreach (var controller in _controllers)
        {
            //set index is created in the controller script bc that is the object calling this method
            controller.SetIndex(index);
            
            //index is incremented
            index++; 
        }
    }

    private void Update()
    {
        //assign a controller to a player based on any input from that controller
        foreach (var controller in _controllers)
        {
            //if the controller is not assigned AND any button is pressed on the controller
            if (controller.IsAssigned == false && controller.AnyButtonDown())
            {
                //assign the controller
                AssignController(controller); 
            }
        }
    }

    void AssignController(Controller controller)
    {
        //set IsAssigned for this controller to true
        controller.IsAssigned = true;
        
        Debug.Log("assigned controller " + controller.gameObject.name);
    }
}
