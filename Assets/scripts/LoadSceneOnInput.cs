using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnInput : MonoBehaviour {


	void Update()
	{
        // waits for the enter key to be pushed and then loaded SchoolScene
        if (Input.GetKey("return"))
        {
            SceneManager.LoadScene("SchoolScene");
    
        }

	}
}
