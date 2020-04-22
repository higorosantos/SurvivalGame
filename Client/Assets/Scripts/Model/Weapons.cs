using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    public class Weapons
    {
        private string name;
        private int bullets = 10;
        private float damage;
        private int maxBullets;
        private float fireSpeed;
        private float speedReload;
        //0 primarias / 1 secundarias
        private int type;
        private float recoil;

        #region Set's
        public void setName(string name)
        {
            this.name = name;
        }
        public void setBullets(int bullets)
        {
            this.bullets = this.bullets + bullets;
        }
        public void setMaxBullets(int maxBullets)
        {
            this.maxBullets = maxBullets;
        }
        public void setType(int type)
        {
            this.type = type;
        }
        public void setRecoil(int recoil)
        {
            this.recoil = recoil;
        }
        public void setDamage(float damage)
        {
            this.damage = damage;
        }
        #endregion
        #region Get's
        public string getName()
        {
            return this.name;
        }
        public int getBullets()
        {
            return this.bullets;
        }
        public float getDamage()
        {
            return this.damage;
        }
        public int getMaxBullets()
        {
            return this.maxBullets;
        }
        public float getSpeedReload()
        {
            return this.speedReload;
        }
        public float getFireSpeed()
        {
            return this.fireSpeed;
        }
        public int getType()
        {
            return this.type;
        }
        public float getRecoil()
        {
            return this.recoil;
        }
        
        #endregion
    }

}
