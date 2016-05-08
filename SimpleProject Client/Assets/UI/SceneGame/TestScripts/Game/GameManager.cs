using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleProject.Sce
{
    class GameManager : MonoBehaviour
    {
        

        private MouseInfo _mouse = new MouseInfo();
        private LinkManager _linkManager = new LinkManager();
        private GameMap _map;

        private Vector2 GetMousePos()
        {
            Vector2 pos;
            pos = Input.mousePosition;
            pos.y = Screen.height - pos.y;
            return pos;
        }

        public void Start()
        {
            
        }

        public void UpdateMouse()
        {
            _mouse.Pos = GetMousePos();
            _mouse.State.Set(Input.GetMouseButton(0));
        }

        public void UpdateLink()
        {
            SimplusWrapper w = null;
            GameObject obj = GetFocusObject();
            if (obj != null)
                w = obj.GetComponent<SimplusWrapper>();
            _linkManager.Update(w, _mouse);
        }

        public GameObject GetFocusObject()
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, -Vector2.up);
            if (hit.collider != null)
            {
                return hit.collider.transform.gameObject;
            }
            return null;
        }

        public void Update()
        {
            UpdateMouse();
            UpdateLink();
        }

    }
}
