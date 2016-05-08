using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SimpleProject.Sce
{
    public class Simplus : MonoBehaviour
    {
        public SimplusWrapper _wrapper;

        private SimplusLink _link;

        public void CreateLink(Simplus destination)
        {
            _link = new SimplusLink(this, destination);
        }
        //public bool IsFocused(Vector2 focusPos)
        //{
        //    return _wrapper.IsFocused(focusPos);
        //}
    }
}
