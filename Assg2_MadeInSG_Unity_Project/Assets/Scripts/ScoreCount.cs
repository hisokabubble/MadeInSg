using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = CollectableCount.Score.ToString();
    }
}
