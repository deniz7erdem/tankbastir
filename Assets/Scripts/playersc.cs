using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playersc : MonoBehaviour
{

    [SerializeField]
    private GameObject Lazer;

     [SerializeField]
    private GameObject tank;

    public int puan=0;

    AudioSource audioSource;

    

    // Start is called before the first frame update
    void Start()
    {
        Canvas Canvas = GameObject.FindObjectOfType<Canvas>();
        Debug.Log(PlayerPrefs.GetInt("bolum"));
        if(SceneManager.GetActiveScene().name=="sahne2"){
            PlayerPrefs.SetInt("bolum", 1);
        }
        InvokeRepeating("Spawn",1f,2f);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(puan>=3&&SceneManager.GetActiveScene().name=="sahne1"){
            StartCoroutine(SahneyiGec());
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            //transform.position += new Vector3(0.0f, -0.01f, 0.0f);
            transform.Translate(new Vector3(0f,-2f,0f)*Time.deltaTime*1f);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            //transform.position += new Vector3(0.0f, 0.01f, 0.0f);
             transform.Translate(new Vector3(0f,2f,0f)*Time.deltaTime*1f);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(Lazer,transform.position+new Vector3(0.6f,-0.1f,0), Quaternion.identity);
            audioSource.loop = false;
            audioSource.Play();
        }


    }

    void Spawn(){
        Vector3 pos = transform.position+new Vector3(20f,Random.Range(-4f,4f),0);
        Instantiate(tank,pos,Quaternion.identity);


    }

    public void puanEkle(){
        this.puan++;
        if(puan>=3&&SceneManager.GetActiveScene().name=="sahne2"){
            SceneManager.LoadSceneAsync("son");
        }
        Debug.Log(this.puan);
    }



IEnumerator SahneyiGec(){

    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("sahne2");

    if (!asyncLoad.isDone)
        {
        yield return null;

        }

    }
}