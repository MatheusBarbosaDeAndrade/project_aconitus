using UnityEngine;


//SCRIPTABLE OBJECT QUE PEGA O NOME E O ICONE DO ITEM A SER ARMAZENADO NO INVENTARIO
[CreateAssetMenu(fileName = "NewItem", menuName = "CreateItem/NewItem")]
public class ItemData : ScriptableObject
{

    public string itemName;
    public Sprite itemIcon;
}
