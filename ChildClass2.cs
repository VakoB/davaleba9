namespace davaleba4
{
    class ChildClass2 : BaseClass2, Interface_2
    {
        double[] arr;
        public ChildClass2(double[] arr) : base(arr)
        {
            this.arr = arr;
        }
        public double Minimum()
        {
            double min = 0.0;
            bool start = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i] || start == false)
                {
                    min = arr[i];
                    start = true;
                }
            }
            return min;
        }

    }
}
