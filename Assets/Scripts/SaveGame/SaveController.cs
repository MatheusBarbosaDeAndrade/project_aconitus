//CONTROLA COMO O SAVE FUNCIONA

using System.IO;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    
    private string saveLocation;
    void Start()
    {
        //CRIA UM ARQUIVO JSON EM UM LOCAL PADR�O
        saveLocation = Path.Combine(Application.persistentDataPath, "saveData.json");
        LoadGame();
    }

    
    public void SaveGame()
    {
        //INSTANCIA E MANIPULA O SCRIPT / A CLASSE SAVEDATA, FAZENDO COM QUE SUAS VARI�VEIS RECEBAM OS DADOS DA CENA EM QUEST�O
        SaveData saveData = new SaveData
        {
            playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position
        };

        //ESCREVE OS DADOS RECEBIDOS ACIMA DENTRO DO ARQUIIVO JSON CRIADO, CONVERTENDO OS DADOS "SAVEDATA" EM TEXTO JSON
        File.WriteAllText(saveLocation, JsonUtility.ToJson(saveData));
    }

     
    public void LoadGame()
    {
        //SE O ARQUIVO JSON AINDA N�O EXISTIR, O PROGRAMA D� UM SAVE NO JOGO LOGO DE CARA, SE O ARQUIVO EXISTIR...
        if (File.Exists(saveLocation))
        {
            //PEGA O ARQUIVO JSON E L� ELE, FAZENDO COM QUE O TEXTO EM JSON SEJA CONVERTIDO NOVAMENTE PARA SCRIPT E SEJA COLOCADO DENTRO DA CLASSE SAVE DATA
            SaveData saveData = JsonUtility.FromJson<SaveData>(File.ReadAllText(saveLocation));

            //COMO OS DADOS JA FORAM CONVERTIDOS PARA C�DIGO, AGORA ELES PODEM SER USADOS COMO C�DIGO (STRINGS, ARRAYS, ETC)
            GameObject.FindGameObjectWithTag("Player").transform.position = saveData.playerPosition;
        }
        else
        {
            SaveGame();
        }
    }
}
