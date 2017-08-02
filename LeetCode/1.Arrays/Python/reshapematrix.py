def matrixReshape(nums, r, c):
    """
    :type nums: List[List[int]]
    :type r: int
    :type c: int
    :rtype: List[List[int]]
    """
    if r*c != len(nums)*len(nums[0]):
        return nums
    nums = [i for item in nums for i in item]
    val = []
    for i in range(0, len(nums), c):
        val.append(nums[i:i+c])
    return val


nums = [[1, 2], [3, 4]]
r = 1
c = 4
print matrixReshape(nums, r, c)
