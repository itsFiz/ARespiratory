using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaviButton : MonoBehaviour
{
    public void ChangeScene(string changethescene)
    {
        SceneManager.LoadScene(changethescene);
    }
}