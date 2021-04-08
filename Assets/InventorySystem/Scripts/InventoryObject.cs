﻿using UnityEngine;

namespace Zhdk.Gamelab.InventorySystem
{
    [CreateAssetMenu(fileName = "NewInventoryObject", menuName = "Inventory System/Inventory Object", order = 0)]
    public class InventoryObject : ScriptableObject
    {
        [Header("Infos")]
        [SerializeField] private string title;
        [SerializeField] private string description;

        [Header("References")]
        [SerializeField] private Sprite sprite;
        [SerializeField] private GameObject prefab;

        [System.NonSerialized] private int pos = 0;

        public string GetTitle()
        {
            return title;
        }

        public string GetDescription()
        {
            return description;
        }

        public Sprite GetSprite()
        {
            return sprite;
        }

        public GameObject GetPrefab()
        {
            return prefab;
        }

        public void SetCurrentPos(int pos)
        {
            this.pos = pos;
        }

        public int GetCurrentPos()
        {
            return pos;
        }

        public virtual void OnAddToInventory(Inventory inventory)
        {
 
        }

        public virtual void OnRemoveFromInventory(Inventory inventory)
        {

        }
    }

}
