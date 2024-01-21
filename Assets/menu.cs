using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void level1() {
        SceneManager.LoadScene("level1");
    }

    public void level2() {
        SceneManager.LoadScene("level2");
    }

    public void level3() {
        SceneManager.LoadScene("level3");
    }
}
