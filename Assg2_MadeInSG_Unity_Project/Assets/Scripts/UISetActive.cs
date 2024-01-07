using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISetActive : MonoBehaviour
{
    public GameObject activeGameObject;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered");
            activeGameObject.SetActive(true);
        }
        
    }
}
