using Raylib_cs;

Raylib.InitWindow(800, 600, "Mickes fantastiska spel GOTY edition");
Raylib.SetTargetFPS(60);

Texture2D enemyTexture = Raylib.LoadTexture("nmy.png");
// Rectangle enemyRect = new Rectangle(
//   0, 0,
//   enemyTexture.width, enemyTexture.height
//   );

List<Rectangle> enemyRects = new List<Rectangle>();

enemyRects.Add(new Rectangle(0, 0, 64, 64));
enemyRects.Add(new Rectangle(300, 0, 64, 64));
enemyRects.Add(new Rectangle(700, 0, 64, 64));


while (!Raylib.WindowShouldClose())
{
  // LOGIK
  for (int i = 0; i < enemyRects.Count; i++)
  {
    Rectangle rect = enemyRects[i];
    rect.y++;
    enemyRects[i] = rect;
  }

  // GRAFIK
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.WHITE);

  foreach (Rectangle rect in enemyRects)
  {
    Raylib.DrawTexture(enemyTexture,
      (int)rect.x,
      (int)rect.y,
      Color.WHITE
    );
  }

  // int i = 2;
  // Raylib.DrawTexture(enemyTexture,
  //   (int)enemyRects[i].x,
  //   (int)enemyRects[i].y,
  //   Color.WHITE
  // );

  Raylib.EndDrawing();
}