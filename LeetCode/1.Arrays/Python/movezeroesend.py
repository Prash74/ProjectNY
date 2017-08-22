"""

"""


def moveZeroes(nums):
    """
    :type nums: List[int]
    :rtype: void Do not return anything, modify nums in-place instead.
    """
    zero = 0
    for i in xrange(len(nums)):
        if nums[i] != 0:
            nums[i], nums[zero] = nums[zero], nums[i]
            zero += 1

nums = [3, 1, 0, 3, 12]
print "Before : ", nums
moveZeroes(nums)
print "After : ", nums
