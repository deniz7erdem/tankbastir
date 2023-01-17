using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sahne_yukle : MonoBehaviour
{
    public Button Devam_btn;

    void Start(){
        Debug.Log(PlayerPrefs.GetInt("bolum"));
        if(PlayerPrefs.GetInt("bolum")==0){
            Devam_btn.interactable = false;
        }else{
            Devam_btn.interactable = true;
            
        }
        
    }

    void Update()
    {

    }

    public void YeniOyun(){
    StartCoroutine(SahneyiGec());
    }

    public void Devam(){
        if(PlayerPrefs.GetInt("bolum")==1){
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("sahne2");
        }
    }

    public IEnumerator SahneyiGec(){


        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("sahne1");

        while (!asyncLoad.isDone)
            {
            yield return null;

            }

        }
}
