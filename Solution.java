class Solution {
    public int[][] matrixReshape(int[][] mat, int r, int c) {
        if(r * c != mat.length * mat[0].length){
            return(mat);
        }

        int[][] ret = new int[r][c];
        int rp = 0;
        int cp = 0;
        for(int i = 0; i < mat.length; i++){
            for(int j = 0; j < mat[i].length; j++){
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
