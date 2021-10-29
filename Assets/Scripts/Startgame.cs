using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartParanoia()
    {
        SceneManager.LoadScene("Paranoia Scene");
    }
}
