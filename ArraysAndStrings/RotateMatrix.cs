namespace ArraysAndStrings
{
    public class RotateMatrix
    {
        public bool Rotate(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length) return false;

            int n = matrix.Length;
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first][i];
                    // bottom left -> top left
                    matrix[first][i] = matrix[last - offset][first];
                    //bottom right -> bottom left
                    matrix[last - offset][first] = matrix[last][last - offset];
                    //top right-> bottom right
                    matrix[last][last - offset] = matrix[i][last];
                    //top left -> top right
                    matrix[i][last] = top;
                }
            }
            return true;
        }
    }
}
