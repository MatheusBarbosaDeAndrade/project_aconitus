using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    public Image[] tabImages;
    public GameObject[] pages;

    void Start()
    {
        ActivateTab(0);
    }

    
    void Update()
    {
        
    }

    public void ActivateTab(int tabNo)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            tabImages[i].color = Color.gray;
            pages[i].SetActive(false);
        }

        tabImages[tabNo].color = Color.white;
        pages[tabNo].SetActive(true);
    }
}
