using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Escape key is being pressed");
            Application.Quit();
        }
    }
}
