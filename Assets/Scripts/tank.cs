using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tank : MonoBehaviour
{
    [SerializeField]
    public GameObject patlama;

    private  playersc playersc;
    // Start is called before the first frame update
    void Start()
    {
        playersc=GameObject.Find("Player").GetComponent<playersc>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*2f*Time.deltaTime);

        if (transform.position.x < -15.0f) {
            Destroy(this.gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D other){

        if(other.tag== "Player"){
            
            SceneManager.LoadScene("sahne1");
            Debug.Log("Çarpisti");
        }else if(other.tag=="Lazer"){
            Debug.Log("lazer vurdu");
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Instantiate(patlama,this.gameObject.transform.position,this.gameObject.transform.rotation);
            playersc.puanEkle();
        }
    }
}
