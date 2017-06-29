/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace HomePage
{
	public partial class Main : GComponent
	{
		public GButton login;
		public GButton exit;
		public GTextInput user;
		public GTextInput psw;

		public const string URL = "ui://zbmfvjnxikgk1";

		public static Main CreateInstance()
		{
			return (Main)UIPackage.CreateObject("HomePage","Main");
		}

		public Main()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			login = (GButton)this.GetChildAt(1);
			exit = (GButton)this.GetChildAt(2);
			user = (GTextInput)this.GetChildAt(3);
			psw = (GTextInput)this.GetChildAt(4);
		}
	}
}