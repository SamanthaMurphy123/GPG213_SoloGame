using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;

    // Update is called once per frame
    void Update()
    {
        // Check if there are any enemies in the scene
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length == 0)
        {
            // Load the next scene
            SceneManager.LoadScene("EndScene");
        }
    }

    
}
