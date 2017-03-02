using System;
namespace Objects
{
	[Serializable]
	public class ProjectV1
	{
		public int int1 { get; set; } = 0;
		public string str1
		{
			get;
			set;
		} = "";


		public ProjectV1()
		{
		}

		public ProjectV1(int intin1)
		{
			int1 = intin1;
		}
		public ProjectV1(int intin1, string strin1)
		{
			int1 = intin1;
			str1 = strin1;
		}
	}
}
