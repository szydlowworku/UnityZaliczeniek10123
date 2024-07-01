using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public CollectibleScript collectibleScript;


    // Update is called once per frame
    void Update()
    {
        int currentScore = collectibleScript.CollectiblesCount();
        ScoreText.text = $"Score: {currentScore}";
    }
}