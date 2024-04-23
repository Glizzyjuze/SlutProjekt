using System.Numerics;
using Raylib_cs;
using SlutProjekt;

public class Projectiles
{
    public Enemy enemy;

    int currentWeaponRotation = 0;
    string currentWeapon = "360";
    int[] bullets;  
    float speed;
    public int fireRate;

    public Vector2 pos;
    int size;
    public Vector2 target;
    Vector2 movement;

    public void Update()
    {
        pos.X += movement.X;
        pos.Y += movement.Y;
        target.X += movement.X;
        target.Y += movement.Y;

        for (int i = 0; i < 300; i++)
        {
            if (currentWeaponRotation < 3)
            {
                currentWeaponRotation += 1;
            }
            else 
            {
                currentWeaponRotation = 0;
            }
            
            i = 0;
        }

        if (currentWeapon == "360")
        {
            speed = 8f;
            
            size = 10;
        }
        
        if (currentWeapon == "shotgun")
        {
            speed = 10f;
            size = 10;
        }

        if (currentWeapon == "grenade")
        {
            speed = 4f;
            size = 50;
        }

        if (currentWeapon == "shotgun" || currentWeapon == "grenade")
        {
            Vector2 diff = target - pos;
            target = Vector2.Normalize(diff);
            movement = target * speed;   
        }
    }

    public void Draw()
    {
        pos = enemy.pos;

        if (currentWeapon == "360")
        {
            bullets = new int[9];
            fireRate = 60;

            foreach (int bullet in bullets)
            {
                Raylib.DrawCircleV(pos, size, Color.Orange);
            }
        }

        if (currentWeapon == "shotgun")
        {
            bullets = new int[2];
            fireRate = 40;

            foreach (int bullet in bullets)
            {
                Raylib.DrawCircleV(pos, size, Color.Orange);
            }
        }

        if (currentWeapon == "grenade")
        {
            fireRate = 180;
            Raylib.DrawCircleV(pos, size, Color.Orange);
        }
    }
}
