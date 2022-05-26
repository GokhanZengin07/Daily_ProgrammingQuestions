using System;

/*
 * The problem
 * You are given an NxN 2D matrix that represents an image. 
 * Rotate the image by 90 degree(cw)
 * 
 */

/*
 * Solution Step-1
 * Transpose Matrix
 * swap(array[i][j],[j][i])
 */
namespace Day_1
{
   
    
    public class Rotate
    {
        

        public int[][] rotateImage2(int[][] matrix)
        {
            int N = matrix.Length;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N/2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][N-1-j];
                    matrix[j][N-1-j] = temp;
                }
            }
            return matrix;
        }

        public int[][] rotateImage(int[][] matrix)
        {
            int N = matrix.Length;

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            return matrix;
        }
    }
    
}
