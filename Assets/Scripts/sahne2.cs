using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahne2 : MonoBehaviour
{
public bool levelComplete = true;
void Update()
{
if(levelComplete)
{
StartCoroutine(SahneyiGec());
}
}
IEnumerator SahneyiGec()
{
yield return new WaitForSeconds(3.0f);
AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("sahne1");
while (!asyncLoad.isDone)
{
yield return null;
}

}
}
