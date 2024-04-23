using System.Numerics;
using Raylib_cs;
using SlutProjekt;

public class Projectiles
{
    int currentWeaponRotation = 0;
    string currentWeapon = "360";
    int[] bullets;  
    float speed;

    public Vector2 pos;
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

        if (currentWeapon == "shotgun" || currentWeapon == "grenade")
        {
            Vector2 diff = target - pos;
            target = Vector2.Normalize(diff);
            movement = target * speed;   
        }
    }

    public void Draw()
    {
        if (currentWeapon == "360")
        {
            bullets = new int[9];
            speed = 8f;

            foreach (int bullet in bullets)
            {
                Raylib.DrawCircleV(pos, 10, Color.Orange);
            }
        }

        if (currentWeapon == "shotgun")
        {
            bullets = new int[2];
            speed = 10f;

            foreach (int bullet in bullets)
            {
                Raylib.DrawCircleV(pos, 10, Color.Orange);
            }
        }

        if (currentWeapon == "grenade")
        {
            speed = 8f;
            Raylib.DrawCircleV(pos, 50, Color.Orange);
        }
    }
}
