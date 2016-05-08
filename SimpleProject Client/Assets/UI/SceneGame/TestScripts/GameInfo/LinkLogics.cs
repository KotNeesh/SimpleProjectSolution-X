using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleProject.Sce
{
    public class LinkLogics
    {
        private SimplusWrapper _focus;
        private SimplusWrapper _source;
        private SimplusWrapper _destination;
        public SimplusWrapper Source
        {
            get
            {
                return _source;
            }
        }
        public SimplusWrapper Destination
        {
            get
            {
                return _destination;
            }
        }
        public SimplusWrapper Focus
        {
            get
            {
                return _focus;
            }
        }
        public bool ToDraw
        {
            get
            {
                return (_source != null && _focus != _source);
            }
        }

        private MessageLink _message;

        public MessageLink GetMessage()
        {
            MessageLink m = _message;
            _message = null;
            return m;
        }

        private void Clear()
        {
            if (_source != null)
            {
                _source.SetPressed(false);
                _source = null;
            }
            
            _destination = null;
            //SetAnimation(_focus, SimplusActionState.Focused);
        }

        public void SetMouseState(MouseState state)
        {
            if (MouseState.Down == state)
            {
                Clear();
                if (_focus != null)
                {
                    _source = _focus;
                    _source.SetPressed(true);
                }
            }
            if (MouseState.Up == state)
            {
                if(_source != null && _focus != null && _focus != _source)
                {
                    Debug.Log("up");
                    _destination = _focus;
                    _message = new MessageLink(this);
                }
                Clear();
            }
        }

        public void SetFocus(SimplusWrapper focus)
        {
            if (focus != _focus)
            {
                if (focus != null)
                {
                    focus.SetFocused(true);
                }
                if (_focus != null)
                {
                    _focus.SetFocused(false);
                }
                _focus = focus;
            }
        }

      
    }
}
