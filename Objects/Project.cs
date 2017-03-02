using System;
namespace Objects
{
	[Serializable]
	public class Project
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
		public string str2
		{
			get;
			set;
		} // TODO null default?

		// CONSTRUCTORS
		public Project()
		{
		}

		public Project(int intin)
		{
			int1 = intin;
		}
		public Project(int intin1, string strin1) : this(intin1)
		{
			str1 = strin1;
		}
		public Project(int intin1, string strin1, int intin2) : this(intin1, strin1)
		{
			int2 = intin2;
		}
		public Project(int intin1, string strin1, int intin2, string strin2) : this(intin1, strin1, intin2)
		{
			str2 = strin2;
		}
	}
}
