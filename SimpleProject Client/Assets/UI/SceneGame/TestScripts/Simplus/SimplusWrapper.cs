﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleProject.Sce 
{
    public class SimplusWrapper : MonoBehaviour, IObj2D
    {
        private SimplusActionState _actionState;
        public GameObject _obj;
        private SimplusAnimationManager _animManager;

        public void Start()
        {
            _animManager = new SimplusAnimationManager(_obj.GetComponent<Animator>());
        }

        public void SetActionState(SimplusActionState state)
        {
            _actionState = state;
            _animManager.SetActionState(state);
        }

        public Vector2 GetPos()
        {
            return _obj.transform.position;
        }

        public Vector2 GetPosSurface(Vector2 destination)
        {
            RaycastHit2D[] hits =  Physics2D.RaycastAll(destination, GetPos());
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].transform.gameObject == _obj)
                {
                    return hits[i].point;
                }
            }
            return Vector2.zero;
        }
    }
}