namespace davaleba4
{
    class ChildClass : BaseClass, Interface_1
    {
        int side_1;
        int side_2;
        int side_3;
        public ChildClass(int side_1, int side_2, int side_3): base(side_1, side_2, side_3)
        {
            this.side_1 = side_1;
            this.side_2 = side_2;
            this.side_3 = side_3;
        }
        public int Perimeter()
        {
            return side_1 + side_2 + side_3;
        }
    }

}
