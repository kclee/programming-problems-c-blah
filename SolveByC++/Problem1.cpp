/* To run, copy the whole thing into Main.cpp */

#include <iostream>
#include <vector>
using namespace std;

namespace Leetcode
{
	class Problem1
	{
	public:
		static void run()
		{
			// Prepare test input
			vector<int> nums = vector<int>{ 2, 7, 11, 15 };
			int target = 9;

			// Get output
			vector<int> result = twoSum(nums, target);
		}

		static vector<int> twoSum(vector<int>& nums, int target)
		{
			// Solution goes here ...

			return vector<int>{1, 0};
		}
	};
}
