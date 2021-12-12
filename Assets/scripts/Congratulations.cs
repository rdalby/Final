using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Congratulations: MonoBehaviour
{


    // Goes back to the opening scene on input
    void Update()
    {
        if(Input.GetKey("return"))
        {
            SceneManager.LoadScene("OpeningScene");
        }
    }
}
