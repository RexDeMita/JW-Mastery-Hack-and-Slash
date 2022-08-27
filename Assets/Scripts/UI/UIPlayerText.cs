 using System;
 using System.Collections;
using System.Collections.Generic;
 using TMPro;
 using UnityEngine;

public class UIPlayerText : MonoBehaviour
{
   //reference to TMP so now it can be edited
   TextMeshProUGUI _tmText;

   Player _player;
   int _playerNumber;

   void Awake()
   {
       //cached the TMP object
       _tmText = GetComponent<TextMeshProUGUI>(); 
       
       //cached player reference
       _player = GetComponentInParent<Player>();

       //Debug.Log( _player);
       
       
   }

   public void HandlePlayerInitialized()
   {
       _playerNumber = _player.PlayerNumber; 
       
       Debug.Log(_playerNumber);
       
       //sets the text of tmText to Player Joined
       _tmText.text = $"Player {_playerNumber} Joined";
       
       //this coroutine will clear the text after a delay
       StartCoroutine(ClearTextAfterDelay());
   }

   IEnumerator ClearTextAfterDelay()
   {
       //wait for 2 secs
       yield return new WaitForSeconds(2);
       
       //empty the contents of tmText
       _tmText.text = String.Empty;
   }
}
