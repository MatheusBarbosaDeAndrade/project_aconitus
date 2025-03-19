using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    //ARRAYS QUE PEGAM AS SESSÕES E AS PÁGINAS DO MENU
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
        //ESTE LAÇO FAZ COM QUE TODAS AS SESSÕES DO MENU ESTEJAM NA COR ESCURA, E TODAS AS PÁGINAS ESTEJAM DESATIVADAS
        for (int i = 0; i < pages.Length; i++)
        {
            tabImages[i].color = Color.gray;
            pages[i].SetActive(false);
        }

        /*O PARÂMETRO DA FUNÇÃO DITARÁ QUAL SESSÃO ESTARÁ CLARA, E JUNTAMENTE COM ISSO, DITARÁ QUAL PÁGINA ESTARÁ VISIVEL.
          UTILIZA-SE O MESMO PARAMETRO DA FUNÇÃO NOS DOIS ARRAYS PARA QUE TENHA UMA SINCRONIA ENTRE UMA SESSÃO E A PÁGINA QUE ESTÁ LIGADA A ESTA SESSÃO.
          OS ITENS DO ARRAY FORAM COLOCADOS PELA UI DA UNITY, E O EVENTO DE CLIQUE COM O MOUSE TAMBÉM.
        */
        tabImages[tabNo].color = Color.white;
        pages[tabNo].SetActive(true);
    }
}
