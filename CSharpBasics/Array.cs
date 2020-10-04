class Array
{
    void Learn1DArray()
    {
        byte[] array1 = new byte[10];

        array1[0] = 23;


        float[] array2 = new float[] { 2.1f, 34.5f, 67.23f };

        char[] array3 = { 'a', 'b', 'c', 'd' };
    }

    void LearnMulDArray()
    {
        //2D Array
        int[,] numbers = new int[13, 44];
        numbers[0, 0] = 123;
        numbers[0, 1] = 456;

        decimal[,] numbers2 = { { 2.3m, 34.5m }, { 56.4m, 12.45m } };
    }


    void LearnJaggedArray()
    {
        short[][] numbers = new short[4][];
        numbers[0] = new short[] { 3, 4, 5 };
        numbers[1] = new short[] { 3, 4 };

    }
}