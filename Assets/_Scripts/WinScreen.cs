using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour {
    public void voltarAoMenu() {
        SceneManager.LoadScene("Menu");
    }
}
