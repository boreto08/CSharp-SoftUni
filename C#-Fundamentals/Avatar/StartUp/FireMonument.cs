﻿namespace StartUp
{
    public class FireMonument : Monument
    {
        private int fireAffinity;

        public FireMonument(string name,int fireAffinity)
            : base(name)
        {
            this.fireAffinity = fireAffinity;
        }

        public int FireAffinity
        {
            get { return this.fireAffinity; }
            set { this.fireAffinity = value; }
        }

    }
}
