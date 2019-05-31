using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Labirint2D
{
    class LabirintGenerator
    {
        struct Node
        {
            public bool path, check;
        }

          public static int Round(int value) 
           {
               if (value % 2 == 0) return value + 1; else return value;
           }
           int Width = 15;
           int Height = 15;
           public int[,] Map;
           int X;
           int Y;

             public void gen()
             {
                 Map = new int[Width, Height];
                 WidthGeneration();
             }

             public void WidthGeneration()
             { 
                 Queue<int> Way = new Queue<int>();
                 for (int i = 0; i < Height; i++)
                     for (int j = 0; j < Width; j++)
                     {
                         Map[i, j] = 1;
                     }
                 Random rnd = new Random();
                 X = 1;
                 Y = 1;
                 Map[X, Y] = 0;
                 Way.Enqueue(X);
                 Way.Enqueue(Y);
                 //построение лабиринта 
                 while (Way.Count > 0)
                 {
                     bool[] nei = Neighbor(X, Y);
                     if (!(nei[0] || nei[1] || nei[2] || nei[3]))
                     {
                         X = Way.Dequeue();
                         Y = Way.Dequeue();
                     }
                     else
                         for (int i = rnd.Next(4), j = 0; j < 4; i++, j++)
                         {
                             if (i > 3)
                                 i = 0;
                             if (nei[i] == true)
                             {
                                 switch (i)
                                 {
                                     case 0:
                                         Map[--X, Y] = 0;
                                         Map[--X, Y] = 0;
                                         break;
                                     case 1:
                                         Map[++X, Y] = 0;
                                         Map[++X, Y] = 0;
                                         break;
                                     case 2:
                                         Map[X, ++Y] = 0;
                                         Map[X, ++Y] = 0;
                                         break;
                                     case 3:
                                         Map[X, --Y] = 0;
                                         Map[X, --Y] = 0;
                                         break;
                                 }
                                 Way.Enqueue(X);
                                 Way.Enqueue(Y);
                                 break;
                             }
                         }
                 }
             }

             private bool[] Neighbor(int x, int y)
             {
                 bool[] way = { false, false, false, false };
                 if (x - 2 >= 0)
                     if (Map[x - 2, y] == 1)
                         way[0] = true;
                 if (x + 2 < Width)
                     if (Map[x + 2, y] == 1)
                         way[1] = true;
                 if (y + 2 < Height)
                     if (Map[x, y + 2] == 1)
                         way[2] = true;
                 if (y - 2 >= 0)
                     if (Map[x, y - 2] == 1)
                         way[3] = true;
                 return way;
             }
         }
     }

   