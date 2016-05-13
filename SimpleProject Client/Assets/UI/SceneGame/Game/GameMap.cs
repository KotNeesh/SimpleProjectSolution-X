using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace SimpleTeam.Sce
{
    public class GameMap : MonoBehaviour
    {
        private ArrayList _simplusContainer = new ArrayList();

        public void Start()
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Simplus");
            foreach (GameObject obj in objects)
            {
                Simplus wrap = obj.GetComponent<Simplus>();
                _simplusContainer.Add(wrap);
            }
        }

        public Simplus GetFocusedSimplus(Vector2 pos)
        {
            foreach (Simplus wrap in _simplusContainer)
            {
                if (wrap._wrapper.IsFocused(pos))
                    return wrap;
            }
            return null;
        }
    }
}
