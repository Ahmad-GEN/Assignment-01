using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash_Script : MonoBehaviour
{
    IEnumerator changeScreen()
    {
        yield return new WaitForSeconds(6.5f);
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(changeScreen());
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}
