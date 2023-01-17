using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmusic : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake(){
        GameObject[] bgmusic = GameObject.FindGameObjectsWithTag("bgmusic");
        if (bgmusic.Length >1){
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
