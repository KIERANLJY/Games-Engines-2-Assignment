using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeupSceneTransition : MonoBehaviour
{
    Scene sceneLoaded;

    // Start is called before the first frame update
    void Start()
    {
        sceneLoaded = SceneManager.GetActiveScene();
        StartCoroutine(LoadNextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
    }   
}
