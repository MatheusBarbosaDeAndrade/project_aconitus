using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Scenario1");
    }
}
