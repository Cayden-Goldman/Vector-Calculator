using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()
        {
            return (float)Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
        }

        public float GetDirection()
        {
            return (float)Math.Atan(this.y / this.x);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v)
        {
            return new Vector(v.x * -1, v.y * -1, v.z * -1);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v, int x)
        {
            return new Vector(v.x * x, v.y * x, v.z * x);
        }

        public static Vector Normalize(Vector v)
        {
            float mag = (float) Math.Sqrt(Math.Pow(v.x, 2) + Math.Pow(v.y, 2) + Math.Pow(v.z, 2));
            return new Vector(v.x / mag, v.y / mag, v.z / mag);
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            return (float)((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            return new Vector((v1.y * v2.z) - (v1.z * v2.y), (v1.z * v2.x) - (v1.x * v2.z), (v1.x * v2.y) - (v1.y * v2.x));
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
            float mag1 = (float)Math.Sqrt(Math.Pow(v1.x, 2) + Math.Pow(v1.y, 2) + Math.Pow(v1.z, 2));
            float mag2 = (float)Math.Sqrt(Math.Pow(v2.x, 2) + Math.Pow(v2.y, 2) + Math.Pow(v2.z, 2));
            float dot = ((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
            return (float)(Math.Acos((dot / (mag1 * mag2))) * (180 / Math.PI));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            float dot = ((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
            float mag2 = (float)Math.Sqrt(Math.Pow(v2.x, 2) + Math.Pow(v2.y, 2) + Math.Pow(v2.z, 2));
            float projNum = (dot) / (mag2*mag2);
            return new Vector((v2.x * projNum), (v2.y * projNum), (v2.z * projNum));
        }
    }
}
