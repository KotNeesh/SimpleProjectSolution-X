using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleTeam.Sce
{
    class GameManager : MonoBehaviour
    {
        private MouseManager _mouse = new MouseManager();
        public LinkManager _linkManager;
        public GameMap _map;

        public void UpdateLink()
        {

            Simplus simplus = _map.GetFocusedSimplus(_mouse.Pos);
 
            _linkManager.UpdateDraw(simplus, _mouse);
        }

        //public GameObject GetFocusObject()
        //{
        //    _map
        //    //return _mouse.MouseOver();
        //    //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //    //RaycastHit hit;
        //    //Vector3 mouseVecFar = new Vector3(mousePos.x, mousePos.y, -100);
        //    //Vector3 mouseVecCls = new Vector3(mousePos.x, mousePos.y, 100);
        //    ////Ray ray = new Ray(mouseVec, Vector3.forward);
        //    //Physics.Raycast(mouseVecFar, mouseVecCls, out hit);
        //    //Debug.DrawLine(mouseVecFar, mouseVecCls);
        //    ////RaycastHit hit = Physics.Raycast(mousePos, Vector2.right, LayerMask.NameToLayer("Simplus"));
        //    //if (hit.collider != null)
        //    //{
        //    //    return hit.collider.transform.gameObject;
        //    //}
        //    //Debug.Log("hit == null");
        //    //return null;
        //}

        public void Update()
        {
            _mouse.Update();
            UpdateLink();
        }

    }
}
