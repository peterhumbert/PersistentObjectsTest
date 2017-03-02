using System;
namespace Objects
{
	[Serializable]
	public class ProjectV2
	{
		public int int1 { get; set; } = 1;
		public string str1
		{
			get;
			set;
		} = "";
		public int int2
		{
			get;
			set;
		} = 2;

		public ProjectV2()
		{
		}

		public ProjectV2(int intin)
		{
			int1 = intin;
		}
		public ProjectV2(int intin1, string strin1)
		{
			int1 = intin1;
			str1 = strin1;
		}
		public ProjectV2(int intin1, string strin1, int intin2)
		{
			int1 = intin1;
			str1 = strin1;
			int2 = intin2;
		}
	}
}
