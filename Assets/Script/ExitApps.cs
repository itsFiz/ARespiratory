using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApps : MonoBehaviour
{
    public void ExitApplication()
    {
        Debug.Log("Keluar Dah application");
        Application.Quit();
    }
}
