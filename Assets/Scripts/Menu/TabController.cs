using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    //ARRAYS QUE PEGAM AS SESS�ES E AS P�GINAS DO MENU
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
        //ESTE LA�O FAZ COM QUE TODAS AS SESS�ES DO MENU ESTEJAM NA COR ESCURA, E TODAS AS P�GINAS ESTEJAM DESATIVADAS
        for (int i = 0; i < pages.Length; i++)
        {
            tabImages[i].color = Color.gray;
            pages[i].SetActive(false);
        }

        /*O PAR�METRO DA FUN��O DITAR� QUAL SESS�O ESTAR� CLARA, E JUNTAMENTE COM ISSO, DITAR� QUAL P�GINA ESTAR� VISIVEL.
          UTILIZA-SE O MESMO PARAMETRO DA FUN��O NOS DOIS ARRAYS PARA QUE TENHA UMA SINCRONIA ENTRE UMA SESS�O E A P�GINA QUE EST� LIGADA A ESTA SESS�O.
          OS ITENS DO ARRAY FORAM COLOCADOS PELA UI DA UNITY, E O EVENTO DE CLIQUE COM O MOUSE TAMB�M.
        */
        tabImages[tabNo].color = Color.white;
        pages[tabNo].SetActive(true);
    }
}
