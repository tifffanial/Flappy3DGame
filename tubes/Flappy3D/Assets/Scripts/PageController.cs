using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mulaiGame(){
        SceneManager.LoadScene("Countdown");
    }

    public void optionGame(){

    }

    public void exitGame(){
        Application.Quit();
    }

    public void backToMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void nextLevel(){

    }
}
