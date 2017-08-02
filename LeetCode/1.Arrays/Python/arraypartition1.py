def arrayPairSum(nums):
    """
    :type nums: List[int]
    :rtype: int
    """
    val = 0
    nums.sort()
    for i in range(0, len(nums), 2):
        val += min(nums[i:i+2])
    return val


nums = raw_input()
nums = nums.split()
nums_arr = [int(i) for i in nums]
print arrayPairSum(nums_arr)
