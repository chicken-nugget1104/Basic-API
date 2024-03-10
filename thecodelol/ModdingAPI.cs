using UnityEngine;
using System.Collections.Generic;

namespace MTM101BMDE
{
    public static class ModdingAPI
    {
        private static Dictionary<string, System.Type> registeredItems = new Dictionary<string, System.Type>();

        // Register an item type with a given name
        public static void RegisterItem(string itemName, System.Type itemType)
        {
            if (!registeredItems.ContainsKey(itemName))
            {
                registeredItems[itemName] = itemType;
            }
            else
            {
                Debug.LogWarning("Item with name " + itemName + " is already registered!");
            }
        }

        // Instantiate and return an item of a given name
        public static Item CreateItem(string itemName)
        {
            if (registeredItems.ContainsKey(itemName))
            {
                System.Type itemType = registeredItems[itemName];
                Item newItem = (Item)System.Activator.CreateInstance(itemType);
                return newItem;
            }
            else
            {
                Debug.LogWarning("Item with name " + itemName + " is not registered!");
                return null;
            }
        }
    }
}