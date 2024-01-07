using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FishCollectable : MonoBehaviour
{
    public static event Action OnCollected;
    
    //On coming into contact with fish, remove it and add 5 points to Score
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            CollectableCount.Score += 5;
            Destroy(gameObject);
            Debug.Log(CollectableCount.Score);
        }
    }

    
}
