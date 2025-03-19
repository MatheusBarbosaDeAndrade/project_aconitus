using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuCanvas;
    void Awake()
    {
        menuCanvas.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            menuCanvas.SetActive(!menuCanvas.activeSelf);
        }
    }
}
