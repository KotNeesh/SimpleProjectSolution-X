﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace SimpleProject.Sce
//{
//    public class LinkInfo
//    {
//        public Simplus Source;
//        public Simplus Destination;
//        public Simplus Focus;
//        private MessageLink _msg;
//        public bool IsReady
//        {
//            get
//            {
//                bool b1 = Source != null;
//                bool b2 = Destination != null;
//                return b1 && b2;
//            }
//        }
//        public void Update(MouseState state)
//        {
//            if (state == MouseState.Down)
//            {
//                Source = Focus;
//            }
//            else if (state == MouseState.Up)
//            {
//                if (Focus == null || Focus == Source || Source == null)
//                {
//                    Source = null;
//                }
//                else
//                {
//                    Destination = Focus;
//                    _msg = new MessageLink(new LinkLogics());
//                }

//            }
//        }
//        public MessageLink GetMessage()
//        {
//            MessageLink msg = _msg;
//            _msg = null;
//            return msg;
//        }
//    }
//}
