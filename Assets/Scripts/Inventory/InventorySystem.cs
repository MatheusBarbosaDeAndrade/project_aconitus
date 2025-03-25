using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewInventory", menuName = "CreateInventory/NewInventory")]
public class InventorySystem : ScriptableObject
{
    //CRIA UMA LISTA COM CADA SLOT DO INVENTORYSLOT
    public List<InventorySlot> slots = new List<InventorySlot>(9);

    //ADICIONA 1 ITEM
    public void AddItem(ItemData newItem)
    {
        //CHECA A LISTA E SE UM ITEM DE UM SLOT FOR IGUAL AO ITEM QUE ESTOU ADICIONANDO NESTE MOMENTO
        //ENTAO AUMENTA A QUANTIDADE DO ITEM
        foreach(InventorySlot slot in slots)
        {
            if(slot.item = newItem)
            {
                slot.quantityItem++;
                return;
            }
        }

        //CASO CONTRÁRIO, ADICIONA O ITEM A UM NOVO SLOT COM A QUANTIDADE DE 1
        if(slots.Count < 9)
        {
            slots.Add(new InventorySlot(newItem, 1));
        }
    }
}
