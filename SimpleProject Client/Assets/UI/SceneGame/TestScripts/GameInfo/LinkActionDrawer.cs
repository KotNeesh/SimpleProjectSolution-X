using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleProject.Sce
{
    public class LinkActionDrawer : MonoBehaviour
    {
        public enum LinkState
        {
            Link,
            Shears
        }

        private GameObject _instance;
        private SpriteRenderer _sprRenderer;
        private float _pixelsPerUnit;
        private float _width;

        private Sprite LinkSprite;
        private Sprite ShearsSprite;

        public void Start()
        {
            LinkSprite = Resources.Load("LinkSprite", typeof(Sprite)) as Sprite;
            ShearsSprite = Resources.Load("ShearsSprite", typeof(Sprite)) as Sprite;
            

            _instance = new GameObject("LinkSpriteInstance");
            _instance.AddComponent<SpriteRenderer>();
            _sprRenderer = _instance.GetComponent<SpriteRenderer>();
            _instance.SetActive(false);
        }
        
        private void SetSpite(LinkState state)
        {
            if (state == LinkState.Link)
                _sprRenderer.sprite = LinkSprite;
            if (state == LinkState.Shears)
                _sprRenderer.sprite = ShearsSprite;

            _pixelsPerUnit = _sprRenderer.sprite.pixelsPerUnit;
            _width = _sprRenderer.sprite.rect.width;
        }

        public void Draw(DragInfo drag, LinkState state)
        {
            //if (state = LinkState.Link)


            //Vector2 SourcePos = drag.GetPosSource();
            //Vector2 DestinationPos = drag.GetPosDestination();

            //var _position = new Vector3(SourcePos.x, SourcePos.y, 0f);
            //var _rotation = Quaternion.Euler(0f, 0f, CalculateAngle(SourcePos, DestinationPos));

            //float scaleNumber = CalculateScale(SourcePos, DestinationPos, PixPerUnit, PixWidth);
            //var _scale = new Vector3(scaleNumber, scaleNumber, 0);

            //_instance.transform.position = _position;
            //_instance.transform.rotation = _rotation;
            //_instance.transform.localScale = _scale;
        }

        float CalculateAngle(Vector2 start, Vector2 end)
        {
            Vector2 difference = end - start;
            difference.Normalize();
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

            return rotZ;
        }

        float CalculateScale(Vector2 start, Vector2 end, int pixPerUnit, int pixWidth)
        {
            return 0;
            //var difference = start - end;
            //float vectorLength = difference.magnitude;

            //float scaleNumber = vectorLength * PixPerUnit / PixWidth;

            //return scaleNumber;
        }

    }
}
