public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
      if(image[sr][sc] == newColor) {
          return image;
      }   
        
      fill(image, image[sr][sc], newColor, sr, sc);
        
      return image;
    }
    
    public void fill(int[][] image, int oldColor, int newColor, int x, int y) {
        if(x < 0 || x >= image.Length || y < 0 || y >= image[x].Length || image[x][y] != oldColor) {
            return;
        }
        
        image[x][y] = newColor;
        fill(image, oldColor, newColor, x + 1, y);
        fill(image, oldColor, newColor, x - 1, y);
        fill(image, oldColor, newColor, x, y + 1);
        fill(image, oldColor, newColor, x, y - 1);
    }
}