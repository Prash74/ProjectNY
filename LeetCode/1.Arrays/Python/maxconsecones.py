"""
Given a binary array, find the maximum number of consecutive 1s in this array.

Example 1:
Input: [1,1,0,1,1,1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s.
    The maximum number of consecutive 1s is 3.
Note:

The input array will only contain 0 and 1.
The length of input array is a positive integer and will not exceed 10,000
"""


def findMaxConsecutiveOnes(nums):
    """
    :type nums: List[int]
    :rtype: int
    """
    max_len, curr_len = 0, 0
    for i in range(len(nums)):
        if nums[i] == 1:
            curr_len += 1
        elif nums[i] != 1:
            curr_len = 0
        max_len = max(max_len, curr_len)
    return max_len

# nums = [0, 1, 1, 0, 1, 1, 1, 1, 0]
nums = [1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1]
# nums = [0, 1]
# nums = [0]
# nums = [1]
print findMaxConsecutiveOnes(nums)
