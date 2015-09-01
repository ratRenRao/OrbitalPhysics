using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitalPhysics
{
    class CelestialObject
    {
        private float diameter, mass, velocity, xpos, ypos;

        public CelestialObject(float diameter, float mass, float velocity, float xpos, float ypos)
        {
            this.diameter = diameter;
            this.mass = mass;
            this.velocity = velocity;
            this.xpos = xpos;
            this.ypos = ypos;
        }

        public float getDiameter() { return diameter; }
        public float getMass() { return mass; }

        public float getVelocity() { return velocity; }
        public void setVelocity(float velocity) { this.velocity = velocity; }

        public float getX() { return xpos; }
        public void setX(float xpos) { this.xpos = xpos; }

        public float getY() { return ypos; }
        public void setY(float ypos) { this.ypos = ypos; }
    }
}