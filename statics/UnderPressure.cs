namespace challenges.Statics
{
  static class UnderPressure
  {
    public static int DoubleInt(int num)
    {
      return num * 2;
    }
    public static bool CanEven(int num)
    {
      return num % 2 == 0;
    }
    public static string GetFileExtension(string str)
    {
      if (str.Contains('.'))
      {
        var strArray = str.Split('.');
        return strArray[strArray.Length - 1];
      }
      return null;
    }

    public static string LongestString(string[] strArray)
    {
      string longestStr = strArray[0];
      for (int i = 0; i < strArray.Length; i++)
      {
        if (strArray[i].Length > longestStr.Length)
        {
          longestStr = strArray[i];
        }
      }
      return longestStr;
    }

    public static int SumArray(int[] nums)
    {
      int total = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        total += nums[i];
      }
      return total;
    }

  }
}