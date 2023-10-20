using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    void OnTriggerEnter(Collider player)
    {
        SceneManager.LoadScene(0);
    }
}
