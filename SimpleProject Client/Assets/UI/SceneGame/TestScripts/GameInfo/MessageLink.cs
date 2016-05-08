using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleProject.Sce
{
    public class MessageLink
    { 
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
        public MessageLink(LinkLogics link)
        {
            _source = link.Source;
            _destination = link.Destination;
        }
    }
}
