using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGhost : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartparanoiaGhost()
    {
        SceneManager.LoadScene("Paranoia Return Scene");
    }
}
