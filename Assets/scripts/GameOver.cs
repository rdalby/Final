using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameOver : MonoBehaviour
{
    public int sceneCount;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        // grabs the total loaded scenes 
        sceneCount = SceneManager.sceneCount;

        // checks if there is at least 2 scenes if not goes back to Title scene
        if (sceneCount >= 2)
        {
            // grabs the name of the previous scene
            sceneName = SceneManager.GetSceneAt(sceneCount - 2).name;
        } 
        else
        {
            sceneName = "OpeningScene";
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("return"))
        {
            SceneManager.LoadScene("DinosaurScene");
        }

        if(Input.GetKey("escape"))
        {
            SceneManager.LoadScene("OpeningScene");
        }
    }
}
