using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleProject.Sce
{
    class GameManager : MonoBehaviour
    {
        public MouseManager _mouse;
        public LinkManager _linkManager;
        private GameMap _map;

        public void UpdateLink()
        {
            SimplusWrapper w = null;
            GameObject obj = GetFocusObject();
            if (obj != null)
                w = obj.GetComponent<SimplusWrapper>();
            _linkManager.UpdateDraw(w, _mouse);
        }

        public GameObject GetFocusObject()
        {
            return _mouse.MouseOver();
            //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //RaycastHit hit;
            //Vector3 mouseVecFar = new Vector3(mousePos.x, mousePos.y, -100);
            //Vector3 mouseVecCls = new Vector3(mousePos.x, mousePos.y, 100);
            ////Ray ray = new Ray(mouseVec, Vector3.forward);
            //Physics.Raycast(mouseVecFar, mouseVecCls, out hit);
            //Debug.DrawLine(mouseVecFar, mouseVecCls);
            ////RaycastHit hit = Physics.Raycast(mousePos, Vector2.right, LayerMask.NameToLayer("Simplus"));
            //if (hit.collider != null)
            //{
            //    return hit.collider.transform.gameObject;
            //}
            //Debug.Log("hit == null");
            //return null;
        }

        public void Update()
        {
            //_mouse.Update();
            UpdateLink();
        }

    }
}
