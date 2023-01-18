using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pausesc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Canvas Canvas = GameObject.FindObjectOfType<Canvas>();
        Canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Canvas Canvas = GameObject.FindObjectOfType<Canvas>();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Canvas.enabled = !Canvas.enabled;
            if (Canvas.enabled)
            {
                Time.timeScale=0f;
            }else
            {
                Time.timeScale=1f;
            }
            

        }


    }


    public void goMain(){
        if(SceneManager.GetActiveScene().name=="sahne2"){
            PlayerPrefs.SetInt("bolum", 1);
        }
        Time.timeScale=1f;
        SceneManager.LoadSceneAsync("AnaMenu");
    }
}
