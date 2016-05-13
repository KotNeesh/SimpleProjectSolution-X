using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SimpleTeam.Sce
{
    public class SimplusLink : MonoBehaviour
    {
        public void SetSimplusLinkData(Simplus source, Simplus destination)
        {
            Debug.Log("SimplusLink constr");
            SimplusWrapper ss = source._wrapper;
            SimplusWrapper dd = destination._wrapper;

            Vector2 s = ss.GetPosSurface(dd.GetPos());
            Vector2 d = dd.GetPosSurface(ss.GetPos());
            //_wrap = new SimplusLinkWrapper(s, d);
            _wrap.SetAnimationState(SimplusLinkActionState.Flying);
            _wrap.SetSimplusLinkWrapperData(s, d);
        }

        private SimplusLinkActionState _state = SimplusLinkActionState.Transporting;

        public SimplusLinkWrapper _wrap;
    }
}
