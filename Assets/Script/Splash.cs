using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    float second;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2.2f);
        SceneManager.LoadScene(1);
    }

}