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

        private SimplusActionStater _stater = new SimplusActionStater();

        private MessageLink _message;

        public MessageLink GetMessage()
        {
            MessageLink m = _message;
            _message = null;
            return m;
        }

        private void Clear()
        {
            _stater.SetPressed(false);
            if (_stater.IsChanged)
                SetAnimation(_source, _stater.GetState());
            _source = null;
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
                    _stater.SetPressed(true);
                    if (_stater.IsChanged)
                        SetAnimation(_source, _stater.GetState());
                }
            }
            if (MouseState.Up == state)
            {
                if(_source != null && _focus != null && _focus != _source)
                {
                    _destination = _focus;
                    _message = new MessageLink(this);
                }
                Clear();
            }
        }

        public void SetFocus(SimplusWrapper focus)
        {
            _stater.SetFocused(focus != null);
            if (_stater.IsChanged)
            {
                SetAnimation(focus, _stater.GetState());
                SetAnimation(_focus, SimplusActionState.Passive);
                
            }
            _focus = focus;
        }

        private void SetAnimation(SimplusWrapper obj, SimplusActionState type)
        {
            if (obj != null)
                obj.SetActionState(type);
        }
    }
}
