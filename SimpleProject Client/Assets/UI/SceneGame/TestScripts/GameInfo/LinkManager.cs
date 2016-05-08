using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleProject.Sce
{
    public class LinkManager : MonoBehaviour
    {
        private LinkLogics _logics;
        public LinkActionDrawer _drawer;

        public void Start()
        {
            _logics = new LinkLogics();
            //_drawer = new LinkActionDrawer();
        }


        public void UpdateDraw(SimplusWrapper simplus, MouseManager mouse)
        {
            _logics.SetFocus(simplus);
            _logics.SetMouseState(mouse.State.Get());

            if (_logics.ToDraw)
            {
                DragInfo drag = new DragInfo();
                drag.SetSource(_logics.Source);
                if (_logics.Focus != null)
                {
                    drag.SetDestination(_logics.Focus);
                }
                else
                {
                    
                    drag.SetDestination(new Point(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
                }
                _drawer.Draw(drag, LinkActionDrawer.LinkState.Link);
            }
            else
                _drawer.NotDraw();
        }
    }
}
