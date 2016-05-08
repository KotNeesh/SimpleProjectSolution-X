using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace SimpleProject.Sce
{
    public class GameMap : MonoBehaviour
    {
        private ArrayList _simplusContainer = new ArrayList();

        public void Start()
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Simplus");
            foreach (GameObject obj in objects)
            {
                SimplusWrapper wrap = obj.GetComponent<SimplusWrapper>();
                _simplusContainer.Add(wrap);
                Debug.Log("added");
            }
        }

        public SimplusWrapper GetFocusedSimplus(Vector2 pos)
        {
            foreach (SimplusWrapper wrap in _simplusContainer)
            {
                if (wrap.IsFocused(pos))
                    return wrap;
            }
            return null;
        }
    }
}
