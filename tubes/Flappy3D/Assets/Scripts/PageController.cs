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

    void mulaiGame(){
        SceneManager.LoadScene("LoseMenu");
    }

    void optionGame(){

    }

    void exitGame(){
        Application.Quit();
    }

    void backToMenu(){

    }

    void nextLevel(){
        
    }
}
