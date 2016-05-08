using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleProject.Sce
{
    public enum SimplusActionState
    {
        Passive,
        Focused,
        Pressed
    }
    public class SimplusActionStater
    {
        private bool _isFocused;
        private bool _isPressed;
        private bool _isChanged;

        public bool IsChanged { get { return _isChanged; } }

        public SimplusActionState GetState()
        {
            _isChanged = false;
            if (_isPressed)
                return SimplusActionState.Pressed;
            if (_isFocused)
                return SimplusActionState.Focused;

            return SimplusActionState.Passive;
        }

        public void SetFocused(bool isFocused)
        {
            _isChanged = !_isPressed && (_isFocused != isFocused);
            _isFocused = isFocused;
        }

        public void SetPressed(bool isPressed)
        {
            _isChanged = (_isPressed != isPressed);
            _isPressed = isPressed;
        }
    }

    
}
