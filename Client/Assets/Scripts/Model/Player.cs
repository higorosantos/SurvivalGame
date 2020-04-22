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

        public void HealHP(float hp)
        {
            this.hp = this.hp + hp;
        }
        public void Damage(float damage)
        {
            this.hp = this.hp - damage;
        }
        public void addExp(float xp)
        {
            this.xp = this.xp + xp;
        }
    }
}