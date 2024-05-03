using System.Numerics;
using Raylib_cs;

namespace SlutProjekt;

public class GameObject
{
    //Både spelarrektangeln och fienderektangeln
    public GameObject()
    {
        rect = new Rectangle(pos, size);
    }

    protected float speed = 7.5f;
   
    public static Vector2 size = new Vector2(70, 70);
    public Vector2 pos = new Vector2(Raylib.GetScreenWidth() / 2 - size.X / 2, Raylib.GetScreenHeight() / 2 - size.Y / 2);

    protected Color color = Color.DarkGreen;
    public Rectangle rect;
    
    //Rita ut rektangeln för både Player och Enemy
    public virtual void Draw()
    {
        Raylib.DrawRectangleRec(rect, color);
    }
    public virtual void Update() {}
}
