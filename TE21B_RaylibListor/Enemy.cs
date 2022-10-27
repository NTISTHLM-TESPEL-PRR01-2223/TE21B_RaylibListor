using Raylib_cs;

public class Enemy
{
  public Rectangle rect;
  public Texture2D image;

  public Enemy()
  {
    image = Raylib.LoadTexture("nmy.png");
    rect = new Rectangle(0, 0, 64, 64);
  }

  public void Draw()
  {
    Raylib.DrawTexture(
      image,
      (int) rect.x,
      (int) rect.y,
      Color.WHITE
    );
  }

}
