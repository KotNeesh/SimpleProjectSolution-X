using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Collections;

namespace SimpleProject.Sce
{
    public class SimplusLinkWrapper : MonoBehaviour
    {
        public SimplusLinkWrapper(Vector2 source, Vector2 destination)
        {
            _source = source;
            _destination = destination;
            _current = destination;

            _partusContainer = new List<GameObject>();
        }

        public void Start()
        {
            LinkSprite = Resources.Load("LinkPart", typeof(Sprite)) as Sprite;

            _pixelsPerUnit = LinkSprite.pixelsPerUnit;
            _width = LinkSprite.rect.width;
        }

        private Vector2 _source;
        private Vector2 _destination;
        private Vector2 _current;

        private List<GameObject> _partusContainer;

        private SpriteRenderer _sprRenderer;
        private float _pixelsPerUnit;
        private float _width;
        private Sprite LinkSprite;

        private SimplusLinkActionState _state;

        private float _resetTim;

        public float FlyInterval = 1f;

        private float _time()
        {
            return Time.time - _resetTime;
        }

        public void SetAnimationState(SimplusLinkActionState state)
        {
            _state = state;
        }

        void ResetTime()
        {
            _resetTime = Time.time;
        }

        public void Update()
        {
            Debug.Log("Update");
            if (_state == SimplusLinkActionState.Transporting)
            {

            }

            if (_state == SimplusLinkActionState.Flying)
            {
                Debug.Log("flying");
                if (_time() < FlyInterval)
                {
                    Debug.Log("<");
                    LaunchPart();
                    ResetTime();
                }
            }
        }

        private void LaunchPart()
        {
            CreatePart();
            SendPart();
        }

        private void CreatePart()
        {
            GameObject part = new GameObject("Link Part" + _partusContainer.Count.ToString());
            part.transform.position = _source;
        }

        private void SendPart()
        {

        }
    }
}
