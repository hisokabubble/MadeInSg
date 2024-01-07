using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeChangeScenee : MonoBehaviour
{
   //Timer to change scene = 5 seconds
    private float Timer = 5f;
    private TextMeshProUGUI timerSeconds;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Deduct time until hits 0
        Timer -= Time.deltaTime;
        timerSeconds.text = Timer.ToString();
        if (Timer <= 0)
        {
            //Change scene when timer hits 0
            SceneManager.LoadScene(0);
        }
    }
}
