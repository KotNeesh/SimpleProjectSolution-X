using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleProject.Sce
{
    public class LinkManager
    {
        private LinkLogics _logics;
        private LinkActionDrawer _drawer;

        public LinkManager()
        {
            _logics = new LinkLogics();
            _drawer = new LinkActionDrawer();
        }

        public void Update(SimplusWrapper simplus, MouseInfo mouse)
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
                    drag.SetDestination(new Point(mouse.Pos));
                }
                _drawer.Draw(drag, LinkActionDrawer.LinkState.Link);
            }
        }
    }
}
