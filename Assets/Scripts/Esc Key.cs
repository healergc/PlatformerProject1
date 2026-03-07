using UnityEngine;
using UnityEngine.SceneManagement;

public class EscKey : MonoBehaviour
{
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScreen");
        }
    }
}
