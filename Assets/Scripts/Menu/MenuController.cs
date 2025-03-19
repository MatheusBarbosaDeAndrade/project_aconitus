/* NESTE SCRIPT, DENTRO AWAKE TEM UMA LINHA DE FAZ COM QUE O MENU FIQUE INATIVO � PRINC�PIO, ENQUANTO NO UPDATE TEM A CONDI��O DE QUE SE O PLAYER CLICAR NA TECLA TAB
 * O MENU APARECE
*/

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
