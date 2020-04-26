using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models { 
    public class PlayerModel
    {
        private string name;
        private float hp = 100;
        private float armor;
        private float stamina = 100;
        private float xp = 0;
        
        

        #region Set's
        public void setName(string name)
        {
            this.name = name;
        }
        public void setArmor(float armor)
        {
            this.armor = armor;
        }
        public void setStamina(float stamina)
        {
            this.stamina = stamina;
        }
        public void setHp(float hp)
        {
            this.hp = hp;
        }
        #endregion

        #region Get's
        public string getName()
        {
            return this.name;
        }
        public float getHp()
        {
            return this.hp;
        }
        public float getArmor()
        {
            return this.armor;
        }
        public float getStamina()
        {
            return this.stamina;
        }
        public float getExp()
        {
            return this.xp;
        }
        #endregion



        public void addExp(float xp)
        {
            this.xp = this.xp + xp;
        }
    }
}