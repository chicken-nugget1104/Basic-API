using System;
using System.Collections;
using UnityEngine;

namespace MTM101BMDE
{
    public class CustomVendingMachine : EnvironmentObject, IItemAcceptor
    {
        [SerializeField]
        private WeightedItemObject[] potentialItems;

        [SerializeField]
        private ItemObject item;

        [SerializeField]
        private ItemObject requiredItem;

        [SerializeField]
        private MeshRenderer meshRenderer;

        private Material[] materials;

        [SerializeField]
        private Material outOfStockMat;

        [SerializeField]
        private int usesLeft = 5;

        public void InsertItem(PlayerManager pm, EnvironmentController ec)
        {
            StartCoroutine(Delay(pm));
            usesLeft--;

            if (usesLeft <= 0 && meshRenderer != null)
            {
                materials = meshRenderer.sharedMaterials;
                materials[1] = outOfStockMat;
                meshRenderer.sharedMaterials = materials;
            }
        }

        public bool ItemFits(Items checkItem)
        {
            return requiredItem.itemType == checkItem && usesLeft > 0;
        }

        private IEnumerator Delay(PlayerManager pm)
        {
            yield return null;

            if (potentialItems.Length != 0)
            {
                ItemManager itm = pm.itm;
                WeightedSelection<ItemObject>[] items = potentialItems;
                itm.AddItem(WeightedSelection<ItemObject>.RandomSelection(items));
            }
            else
            {
                pm.itm.AddItem(item);
            }
        }
    }
}