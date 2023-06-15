using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube1")
        {
            SceneManager.LoadScene("Build");
        }
        if (collision.gameObject.name == "Cube2")
        {
            SceneManager.LoadScene("Build");
        }
        if (collision.gameObject.name == "Cube3")
        {
            SceneManager.LoadScene("Build");
        }
        if (collision.gameObject.name == "Cube4")
        {
            SceneManager.LoadScene("Build");
        }
    }
}
