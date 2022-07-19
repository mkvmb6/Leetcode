public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        return FloodFill(image, sr, sc, color, image[sr][sc]);
    }
    public int[][] FloodFill(int[][] image, int sr, int sc, int color, int oldColor) {
        if(sr<0 || sc<0 || sr>=image.Length|| sc>=image[0].Length || image[sr][sc]!=oldColor || image[sr][sc]==color){
            return image;
        }
        image[sr][sc]=color;
        FloodFill(image, sr+1, sc, color, oldColor);
        FloodFill(image, sr-1, sc, color, oldColor);
        FloodFill(image, sr, sc+1, color, oldColor);
        FloodFill(image, sr, sc-1, color, oldColor);
        return image;

    }
}