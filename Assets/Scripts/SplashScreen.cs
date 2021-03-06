using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SplashScreenWait());
    }
    IEnumerator SplashScreenWait()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
