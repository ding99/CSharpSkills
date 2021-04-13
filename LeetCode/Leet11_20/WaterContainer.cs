/*
 Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of the line i is at (i, ai) and (i, 0). Find two lines, which, together with the x-axis forms a container, such that the container contains the most water.

Notice that you may not slant the container.
 */

using System;

namespace LeetCode.Leet11_20 {
	public class WaterContainer {
		public void Start() {
			Action(new int[] {1, 8, 6,2,5,4,8,3,7});
			Action(new int[] {1, 1});
			Action(new int[] {4,3,2,1,4});
			Action(new int[] { 1, 2,1 });
		}

		private void Action(int[] heights) {
			int n = heights.Length, max = 0, mid;
			
			if(n > 1)
				for(int i = 0; i + 1 < n; i++)
					for (int j = i + 1; j < n; j++)
						if((mid = (j - i) * (heights[i] > heights[j] ? heights[j] : heights[i])) > max)
								max = mid;

			Console.WriteLine($"size [{n}], max-volume [{max}]");
		}
	}
}
