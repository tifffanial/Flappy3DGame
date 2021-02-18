using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public Text startText1; // used for showing countdown from 3, 2, 1     void Start()
    public Text startText2; // used for showing countdown from 3, 2, 1     void Start()

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText1.text = (timeLeft).ToString("0");
        startText2.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("MainGame");
        }
    }
}
