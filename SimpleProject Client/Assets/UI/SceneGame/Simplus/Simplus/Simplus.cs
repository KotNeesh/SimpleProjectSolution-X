using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SimpleTeam.Sce
{
    public class Simplus : MonoBehaviour
    {
        public SimplusWrapper _wrapper;

        public GameObject LinkPrefab;

        private SimplusLink _link;

        public void CreateLink(Simplus destination)
        {
            //_link = new SimplusLink(this, destination);
            GameObject linkObj = Instantiate(LinkPrefab);
            _link = linkObj.GetComponent<SimplusLink>();
            _link.SetSimplusLinkData(this, destination);
        }
        //public bool IsFocused(Vector2 focusPos)
        //{
        //    return _wrapper.IsFocused(focusPos);
        //}
    }
}
