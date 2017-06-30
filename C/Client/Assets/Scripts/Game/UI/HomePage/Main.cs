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

			login = (GButton)this.GetChild("login");
			exit = (GButton)this.GetChild("exit");
			user = (GTextInput)this.GetChild("user");
			psw = (GTextInput)this.GetChild("psw");
		}
	}
}