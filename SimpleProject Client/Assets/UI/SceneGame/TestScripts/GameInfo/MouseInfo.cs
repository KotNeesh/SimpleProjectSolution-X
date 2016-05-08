using UnityEngine;

namespace SimpleProject.Sce
{
    public enum MouseState
    {
        Nope,
        Down,
        Pressed,
        Up
    }
    public class MouseButtonState
    {
        MouseState _state;
        public void Set(bool isPressed)
        {
            if (isPressed)
            {
                switch (_state)
                {
                    case MouseState.Pressed:
                        break;
                    case MouseState.Down:
                        _state = MouseState.Pressed;
                        break;
                    case MouseState.Nope:
                        _state = MouseState.Down;
                        break;
                    case MouseState.Up:
                        _state = MouseState.Down;
                        break;
                }
            }
            else
            {
                switch (_state)
                {
                    case MouseState.Nope:
                        break;
                    case MouseState.Up:
                        _state = MouseState.Nope;
                        break;
                    case MouseState.Pressed:
                        _state = MouseState.Up;
                        break;
                    case MouseState.Down:
                        _state = MouseState.Up;
                        break;
                }
            }
        }
        public MouseState Get()
        {
            return _state;
        }
    }
    public class MouseInfo
    {
        public Vector2 Pos;
        public MouseButtonState State = new MouseButtonState();
    }
}
