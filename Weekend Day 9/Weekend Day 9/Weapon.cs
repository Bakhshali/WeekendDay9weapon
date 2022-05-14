using System;
using System.Collections.Generic;
using System.Text;

namespace Weekend_Day_9
{
    class Weapon
    {
        private  int _count;

        public int BulletCapacity { get; set; }
        public int BulletCount
        {
            get
            {
                return _count;
            }
            set
            {
                if (value>0 && value<BulletCapacity)
                {
                    _count = value;
                }
            }
        }
        public bool Mood { get; set; }

        public void Shoot()
        {
            Console.WriteLine(BulletCount-=1);

        }

        public void Fire()
        {
            if (Mood==false)
            {
                Console.WriteLine(BulletCount = 0);
            }
            
        }
       

        public int GetRemainBulletCount()
        {
            return BulletCapacity -= BulletCount;
        }

        public int Reload()
        {
            return BulletCapacity = BulletCount + GetRemainBulletCount();
        }

        public void ChangeFireMode()
        {
            if (Mood==true)
            {
                Console.WriteLine(false);
            }
            else if (Mood == false)
            {
                Console.WriteLine(true);
            }
        }

        public Weapon(int capacity,int count)
        {
            BulletCapacity = capacity;
            BulletCount = count;
        }

    }
}
