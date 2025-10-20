class Solution:
    def matrixReshape(self, mat, r, c):
        if r * c != len(mat) * len(mat[0]):
            return mat

        ret = []
        t = []
        for i in range(len(mat)):
            for j in range(len(mat[i])):
                t.append(mat[i][j])
                if len(t) == c:
                    ret.append(t)
                    t = []
        
        return ret
