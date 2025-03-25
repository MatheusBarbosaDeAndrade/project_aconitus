using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Scenario1");
    }
}
