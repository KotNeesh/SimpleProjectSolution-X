using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SimpleProject.Sce
{
    public class SimplusLink : MonoBehaviour
    {
        public SimplusLink(Simplus source, Simplus destination)
        {
            SimplusWrapper ss = source._wrapper;
            SimplusWrapper dd = destination._wrapper;

            Vector2 s = ss.GetPosSurface(dd.GetPos());
            Vector2 d = dd.GetPosSurface(ss.GetPos());
            _wrap = new SimplusLinkWrapper(s, d);
            _wrap.SetAnimationState(SimplusLinkActionState.Flying);
        }

        private SimplusLinkActionState _state = SimplusLinkActionState.Transporting;

        public SimplusLinkWrapper _wrap;
    }
}
