using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models { 
    public class PlayerModel
    {
        private string name;
        private float hp;
        private float armor;

        public void setName(string name)
        {
            this.name = name;


        }
        public string getName()
        {
            return this.name;
        }
}
}