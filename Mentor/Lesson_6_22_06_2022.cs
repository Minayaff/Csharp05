class Program
    {
        static void Main(string[] args)
        {
            #region Ref and Out


            int number = 15;
            Console.WriteLine(number);
            SquareNumber(ref number);
            Console.WriteLine(number);


            Console.WriteLine(number);
            CubeNumber(out number);
            Console.WriteLine(number);


            int[] nums = { 1, 2, 3, 4, 5, 6 };
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");

            ChangeNumber(nums);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            #endregion

            

        }

        public static int[] SortedSquares(int[] nums)
        {
            Squares(nums);
            Array.Sort(nums);
            return nums;
        }

        public static int[] Squares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int element = nums[i];
                nums[i] = element * element;
            }
            return nums;
        }

        public static int[] Sort(int[] nums)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == 0)
                {

                    for (int i = j; i < nums.Length-1; i++)
                    {
                        int number = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = number;
                    }
                   

                    //    0,1,0,3,12
                    //    1,0,3,12,0
                    //    1,3,12,0,0
                }
            }

            return nums;
        }

        #region Ref and Out


        public static void ChangeNumber(int[] nums)
        {
            nums[0] = 7;
        }


        public static void SquareNumber(ref int num)
        {
            num = num * num;
        }


        public static void CubeNumber(out int num)
        {
            num = 5;
            num = num * num * num;
        }

        #endregion
    }
