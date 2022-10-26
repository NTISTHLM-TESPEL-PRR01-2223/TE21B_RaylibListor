using Raylib_cs;

Raylib.InitWindow(800, 600, "Mickes fantastiska spel GOTY edition");
Raylib.SetTargetFPS(60);

Texture2D enemyTexture = Raylib.LoadTexture("nmy.png");
Rectangle enemyRect = new Rectangle(
  0, 0,
  enemyTexture.width, enemyTexture.height
  );

while (!Raylib.WindowShouldClose())
{
  // LOGIK

  // GRAFIK
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.WHITE);

  Raylib.DrawTexture(enemyTexture,
    (int)enemyRect.x,
    (int)enemyRect.y,
    Color.WHITE
  );

  Raylib.EndDrawing();
}