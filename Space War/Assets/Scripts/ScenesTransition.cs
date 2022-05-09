using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesTransition : MonoBehaviour
{
    Scene sceneLoaded;

    // Start is called before the first frame update
    void Start()
    {
        sceneLoaded = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BattleShip"))
        {
            SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
        }
    }
}
