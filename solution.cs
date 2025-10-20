public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        if(r * c != mat.Length * mat[0].Length){
            return(mat);
        }
        
        int[][] ret = new int[r][];
        for (int i = 0; i < r; i++) {
            ret[i] = new int[c];
        }
        int rp = 0;
        int cp = 0;
        for(int i = 0; i < mat.Length; i++){
            for(int j = 0; j < mat[i].Length; j++){
                ret[rp][cp] = mat[i][j];
                cp++;
                if(cp == c){
                    cp = 0;
                    rp++;
                }
            }
        }

        return(ret);
    }
}
