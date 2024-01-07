using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    //Count down variables for game start
    public float currentTime = 0f;
    public float startingTime = 5f;
    [SerializeField] TextMeshProUGUI coundownText;
    public GameObject toDisable;
    public GameObject toEnable;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        //minus one second when counting down
        currentTime -= 1 * Time.deltaTime;
        coundownText.text = currentTime.ToString("0");

        if(currentTime <= 3)
        {
            //Counting down from 5, when it hits 3,2,1, turn numbers red
            coundownText.color = Color.red;
        }
        if (currentTime <= 0)
        {
            //start game
            currentTime = 0;
            toDisable.SetActive(false);
            toEnable.SetActive(true);
        }
    }
}
