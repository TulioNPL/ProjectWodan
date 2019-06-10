using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fim : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("End"))
        {
            Debug.Log("LOLOLOLOLOLOLOL");
            SceneManager.LoadScene("WinMenu");
        }
    }
}