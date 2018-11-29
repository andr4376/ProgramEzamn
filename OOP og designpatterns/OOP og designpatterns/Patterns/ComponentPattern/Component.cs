﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    abstract class Component
    {
        private GameObject gameObject;

        public GameObject GameObject
        {
            get { return gameObject; }
        }

        public Component(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }

        public Component()
        {

        }
    }
}


