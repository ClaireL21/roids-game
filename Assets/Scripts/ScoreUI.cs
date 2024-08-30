using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    Global globalObj;
    TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject g = GameObject.Find("GlobalObject");
        globalObj = g.GetComponent<Global>();
        Debug.Log("globalObj = " + globalObj);
        scoreText = gameObject.GetComponent<TMP_Text>();
        Debug.Log("score text = " + scoreText);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = globalObj.score.ToString();
    }
}
