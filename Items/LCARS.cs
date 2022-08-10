using Terraria;
using Terraria.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ModLoader;
using Terraria.Audio;
using Terraria.ID;
using Terraria.GameContent.UI.Elements;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework.Input;
using Terraria.GameInput;

    namespace TrekTech.Items
    {
        class LCARS : UIElement
        {
            public bool first = true;
            public Vector2 v;

            Asset<Texture2D> Front = ModContent.Request<Texture2D>($"TrekTech/Items/LCARS_Front");
            Asset<Texture2D> Back = ModContent.Request<Texture2D>($"TrekTech/Items/LCARS_Back");

            public override void Draw(SpriteBatch spriteBatch)
            {
                if(first) {
                    //Main.NewText(Main.screenHeight.ToString() + ", " + v.Y.ToString(), 100, 0 , 0);
                    v = new Vector2(Main.screenWidth, Main.screenHeight);  
                    first = false;
                }
                if(v.Y > (Main.screenHeight / 2f) - 224){
                    v.Y = v.Y - 30;
                }
                spriteBatch.Draw((Texture2D)Back, new Vector2((v.X / 2f) - 300, v.Y), Microsoft.Xna.Framework.Color.White);
                spriteBatch.Draw((Texture2D)Front, new Vector2((v.X / 2f) - 300, v.Y), Microsoft.Xna.Framework.Color.White);
            }
        }

        class LCARSButton : UIImageButton
        {
            public bool first = true;
            public Vector2 v;
            int DrawPos;

            Asset<Texture2D> Front;

            public LCARSButton(Asset<Texture2D> texture, int DrawPos) : base(texture){
                this.SetImage(texture);
                this.SetVisibility(1f,1f);
                this.Front = texture;
                this.DrawPos = DrawPos;
            }

            protected override void DrawSelf(SpriteBatch spriteBatch) {
                base.DrawSelf(spriteBatch);
            }
            public override void Draw(SpriteBatch spriteBatch)
            {
                if(first) {
                    //Main.NewText(Main.screenHeight.ToString() + ", " + v.Y.ToString(), 100, 0 , 0);
                    v = new Vector2(Main.screenWidth, Main.screenHeight);  
                    first = false;
                }
                switch (DrawPos)
                {
                    case 1:
                        if(v.Y > (Main.screenHeight / 2f) - 224){
                            v.Y = v.Y - 30;
                        }
                        spriteBatch.Draw((Texture2D)Front, new Vector2((v.X / 2f) + 102, v.Y + 96), Microsoft.Xna.Framework.Color.White);
                        break;
                    case 2:
                        if(v.Y > (Main.screenHeight / 2f) - 224){
                            v.Y = v.Y - 30;
                        }
                        spriteBatch.Draw((Texture2D)Front, new Vector2((v.X / 2f) + 102, v.Y + 62), Microsoft.Xna.Framework.Color.White);
                        break;
                    case 3:
                        if(v.Y > (Main.screenHeight / 2f) - 224){
                            v.Y = v.Y - 30;
                        }
                        spriteBatch.Draw((Texture2D)Front, new Vector2((v.X / 2f) + 200, v.Y + 62), Microsoft.Xna.Framework.Color.White);
                        break;
                    case 4:
                        if(v.Y > (Main.screenHeight / 2f) - 224){
                            v.Y = v.Y - 30;
                        }
                        spriteBatch.Draw((Texture2D)Front, new Vector2((v.X / 2f) + 200, v.Y + 96), Microsoft.Xna.Framework.Color.White);
                        break;
                }
            }
        }

        class PADDFrame : UIElement
        {
            public bool first = true;
            public Vector2 v;

            Asset<Texture2D> Front = ModContent.Request<Texture2D>($"TrekTech/Items/PADD_Frame");

            public override void Draw(SpriteBatch spriteBatch)
            {
                if(first) {
                    //Main.NewText(Main.screenHeight.ToString() + ", " + v.Y.ToString(), 100, 0 , 0);
                    v = new Vector2(Main.screenWidth, Main.screenHeight);  
                    first = false;
                }
                if(v.Y > (Main.screenHeight / 2f) - 224){
                    v.Y = v.Y - 30;
                }
                spriteBatch.Draw((Texture2D)Front, new Vector2((v.X / 2f) - 384, v.Y - 80), Microsoft.Xna.Framework.Color.White);
            }  
        }

        class PADDMapSquare : UIElement
        {
            bool first = true;
            float x;
            float y;
            public int type;
            Asset<Texture2D> square;
            float start;
            Vector2 star;
            bool firstupdate;

            public PADDMapSquare(float nx, float ny, int type, Asset<Texture2D> square, float start, bool firstupdate){
                this.x = (nx + (Main.screenWidth  / 2f) - 124);
                this.y = (ny + (Main.screenHeight / 2f) - 26);
                this.type = type;
                this.square = square;
                if(firstupdate == false){
                    star = new Vector2(x, Main.screenHeight + y - 260);
                    //this.start = Main.screenHeight + y;
                }
                else{
                    star = new Vector2(x, y);
                }

            }

            public override void Draw(SpriteBatch spriteBatch)
            {
                if(star.Y - 15 > y){
                    star.Y = star.Y - 30;
                }
                else{
                    star.Y = y;
                }


                if(this.type == 0){
                    this.type = 20;
                }
                spriteBatch.Draw((Texture2D)square, new Vector2(x,star.Y), new Color(0,0,(type) * 7));
                // PictureBox b = new PictureBox()
                // Graphics g = System.CreateGraphics();
                // g.DrawRectangle(new Pen((0,0,type), 1), x, y, 4, 4);   
            }  
        }
    }