using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class walls : Figure
    {
        public List<Figure> wallList; 
        
        public walls(int upLeftX, int upLeftY, int downRightX, int downRightY, char symbol)
        {
            this.wallList = new List<Figure>();
            
            HorizontalLine upLine = new HorizontalLine(upLeftX, downRightX, upLeftY, symbol);
            wallList.Add (upLine);
            HorizontalLine downLine = new HorizontalLine(upLeftX, downRightX, downRightY, symbol);
            wallList.Add (downLine);
            VerticalLine leftLine = new VerticalLine(upLeftY, downRightY, upLeftX, symbol);
            wallList.Add (leftLine);
            VerticalLine rightLine = new VerticalLine(upLeftY, downRightY, downRightX, symbol);
            wallList.Add(rightLine);
        }

        public new void Draw()
        {
            foreach (var wall in wallList)
                wall.Draw();
        }

        public new bool isHit(Figure figure)
        {
            foreach (var f in wallList)
                if (f.isHit(figure))
                    return true;
            return false;
        }
    }
}
