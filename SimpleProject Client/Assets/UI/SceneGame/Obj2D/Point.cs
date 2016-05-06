using System;
using UnityEngine;

namespace SimpleProject.Sce
{
    public class Point : IObj2D
    {
        private Vector2 _pos;
        public Point(Vector2 pos)
        {
            _pos = pos;
        }
        public Vector2 GetPos()
        {
            return _pos;
        }

        public Vector2 GetPosSurface(Vector2 destination)
        {
            return _pos;
        }

        public bool IsFocus(Vector2 focusPos)
        {
            return focusPos.Equals(_pos);
        }
    }
}
